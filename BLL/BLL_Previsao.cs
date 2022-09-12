using ClimaTempo.DAL;
using ClimaTempo.Models.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ClimaTempo.BLL
{
    public interface IBLL_Previsao
    {
        IEnumerable<Cidade> ObterCidades();
        RankingPrevisao ObterRanking(int quantidade = 3);
        IEnumerable<PrevisaoDoTempo> ObterResumo(DateTime DataInicial, int CidadeId);
    }

    public class BLL_Previsao : IBLL_Previsao
    {
        private readonly IDAL_Previsao _previsao;

        public BLL_Previsao(IDAL_Previsao previsao)
        {
            _previsao = previsao;
        }

        public RankingPrevisao ObterRanking(int quantidade = 3)
        {
            RankingPrevisao rankingPrevisao = new RankingPrevisao()
            {
                TopQuentes = _previsao.ObterTopQuentes(quantidade),
                TopFrias = _previsao.ObterTopFrias(quantidade)
            };

            return rankingPrevisao;
        }

        public IEnumerable<PrevisaoDoTempo> ObterResumo(DateTime DataInicial, int CidadeId)
        {
            return _previsao.ObterResumo(DataInicial, CidadeId);
        }

        public IEnumerable<Cidade> ObterCidades()
        {
            return _previsao.ObterCidades();
        }
    }
}
