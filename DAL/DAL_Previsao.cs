using ClimaTempo.Models.Entities;
using ClimaTempo.Models.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClimaTempo.DAL
{
    public interface IDAL_Previsao
    {
        IEnumerable<Models.ViewModels.Cidade> ObterCidades();
        IEnumerable<PrevisaoDoTempo> ObterResumo(DateTime dataInicial, int CidadeId);
        IEnumerable<PrevisaoDoTempo> ObterTopFrias(int quantidade = 3);
        IEnumerable<PrevisaoDoTempo> ObterTopQuentes(int quantidade = 3);
    }

    public class DAL_Previsao : IDAL_Previsao
    {
        private readonly ClimaTempoSimplesContext _context;

        public DAL_Previsao(ClimaTempoSimplesContext context)
        {
            _context = context;
        }

        public IEnumerable<PrevisaoDoTempo> ObterTopQuentes(int quantidade = 3)
        {
            var topQuentes = (from previsao in _context.PrevisoesClima
                              join cidade in _context.Cidades on previsao.CidadeId equals cidade.Id
                              join estado in _context.Estados on cidade.EstadoId equals estado.Id
                              where previsao.DataPrevisao.Date == DateTime.Now.Date
                              orderby previsao.TemperaturaMaxima descending
                              select new PrevisaoDoTempo
                              {
                                  Cidade = cidade.Nome,
                                  UF = estado.UF,
                                  DataPrevisao = previsao.DataPrevisao,
                                  Clima = previsao.Clima.ToString(),
                                  Max = previsao.TemperaturaMaxima,
                                  Min = previsao.TemperaturaMinima
                              }).Take(quantidade).ToList();

            return topQuentes;
        }

        public IEnumerable<PrevisaoDoTempo> ObterTopFrias(int quantidade = 3)
        {
            var topFrias = (from previsao in _context.PrevisoesClima
                            join cidade in _context.Cidades on previsao.CidadeId equals cidade.Id
                            join estado in _context.Estados on cidade.EstadoId equals estado.Id
                            where previsao.DataPrevisao.Date == DateTime.Now.Date
                            orderby previsao.TemperaturaMinima
                            select new PrevisaoDoTempo
                            {
                                Cidade = cidade.Nome,
                                UF = estado.UF,
                                DataPrevisao = previsao.DataPrevisao,
                                Clima = previsao.Clima.ToString(),
                                Max = previsao.TemperaturaMaxima,
                                Min = previsao.TemperaturaMinima
                            }).Take(3).ToList();

            return topFrias;
        }

        public IEnumerable<PrevisaoDoTempo> ObterResumo(DateTime dataInicial, int CidadeId)
        {
            var resumo = (from previsao in _context.PrevisoesClima
                          join cidade in _context.Cidades on previsao.CidadeId equals cidade.Id
                          join estado in _context.Estados on cidade.EstadoId equals estado.Id
                          where cidade.Id == CidadeId
                          where previsao.DataPrevisao.Date >= dataInicial.Date
                          select new PrevisaoDoTempo
                          {
                              Cidade = cidade.Nome,
                              UF = estado.UF,
                              DataPrevisao = previsao.DataPrevisao,
                              Clima = previsao.Clima.ToString(),
                              Max = previsao.TemperaturaMaxima,
                              Min = previsao.TemperaturaMinima
                          }).Take(7).ToList();
            return resumo;
        }

        public IEnumerable<Models.ViewModels.Cidade> ObterCidades()
        {
            var cidades = (from cidade in _context.Cidades
                           select new Models.ViewModels.Cidade
                           {
                               Id = cidade.Id,
                               Nome = cidade.Nome,
                               UF = cidade.Estado.UF
                           }).ToList();

            return cidades;
        }
    }
}
