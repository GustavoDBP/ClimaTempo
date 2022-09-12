using ClimaTempo.BLL;
using ClimaTempo.DAL;
using ClimaTempo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ClimaTempo.Controllers
{
    [Route("previsao")]
    public class PrevisaoController : Controller
    {
        private IBLL_Previsao _previsao;

        public PrevisaoController(IBLL_Previsao previsao)
        {
            _previsao = previsao;
        }

        [HttpGet("ranking")]
        public IActionResult Ranking()
        {
            var ranking = _previsao.ObterRanking(3);

            return Json(ranking);
        }

        [HttpGet("resumo/{cidadeId}")]
        public IActionResult Overview(int cidadeId)
        {
            var resumo = _previsao.ObterResumo(DateTime.Now, cidadeId);

            return Json(resumo);
        }

        [HttpGet("cidades")]
        public IActionResult Cities()
        {
            var cidades = _previsao.ObterCidades();

            return Json(cidades);
        }
    }
}
