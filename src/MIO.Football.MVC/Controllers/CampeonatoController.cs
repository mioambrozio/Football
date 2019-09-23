using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MIO.Football.Application.Interfaces;
using MIO.Football.Application.ViewModel.Campeonato;
using MIO.Football.Application.ViewModel.Matches;
using MIO.Football.Application.ViewModel.Standings;
using MIO.Football.Application.ViewModel.Team;
using System;

namespace MIO.Football.MVC.Controllers
{
    [Route("")]
    [Route("Campeonato")]
    public class CampeonatoController : BaseController
    {
        private readonly ICampeonatoApplicationService _campeonatoService;
        public CampeonatoController(ICampeonatoApplicationService campeonatoService)
        {
            _campeonatoService = campeonatoService;
        }

        public IActionResult Index()
        {
            return ReturnView("Index");
        }

        [Route("Pesquisa")]
        [HttpPost]
        public IActionResult SearchCompetitions(IFormCollection form)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(form["Search"]))
                {
                    CampeonatoViewModel result = _campeonatoService.SearchCompetitions(form["Search"].ToString());

                    HttpContext.Session.SetString("NomeCampeonato", result.name);
                    HttpContext.Session.SetString("AreaCampeonato", result.area.name + " - " + result.name);
                    HttpContext.Session.SetString("PeríodoCampeonato", result.currentSeason.startDate.Value.Month.ToString() + "/" + result.currentSeason.startDate.Value.Year.ToString() + " até " + result.currentSeason.endDate.Value.Month.ToString() + "/" + result.currentSeason.endDate.Value.Year.ToString());

                }
                HttpContext.Session.SetString("IdCampeonato", form["Search"]);
                SessionValid();
            }
            catch (Exception ex)
            {
                HttpContext.Session.SetString("NomeCampeonato", "");
                HttpContext.Session.SetString("IdCampeonato", "");
                ViewBag.error = "Ocorreu um erro inesperado. Erro:" + ex.Message;
            }
            return View("Index");
        }

        [Route("Classificacao")]
        public IActionResult Classificacao()
        {
            StandingsEntityViewModel viewModel = new StandingsEntityViewModel();
            try
            {
                string IdCampeonato = HttpContext.Session.GetString("IdCampeonato");
                SessionValid();
                if (!string.IsNullOrWhiteSpace(IdCampeonato))
                {
                    StandingsEntityViewModel result = _campeonatoService.SearchStandings(IdCampeonato);


                    if (result != null)
                    {
                        viewModel = result;
                    }
                    else
                    {
                        ViewBag.error = "Ops. Não houve retorno de classificação!";
                    }
                }
            }
            catch (Exception ex)
            {
                HttpContext.Session.SetString("NomeCampeonato", "");
                HttpContext.Session.SetString("IdCampeonato", "");
                ViewBag.error = "Ocorreu um erro inesperado. Erro:" + ex.Message;
            }
            return ReturnView("Classificacao", viewModel);
        }

        [Route("Times")]
        public IActionResult Times()
        {
            TeamCompleteViewModel viewModel = new TeamCompleteViewModel();
            try
            {
                //string IdCampeonato = HttpContext.Session.GetString("IdCampeonato");
                SessionValid();
                if (!string.IsNullOrWhiteSpace(IdCampeonato))
                {
                    TeamCompleteViewModel result = _campeonatoService.ListTeams(IdCampeonato);

                    if (result != null)
                    {
                        viewModel = result;
                    }
                    else
                    {
                        ViewBag.error = "Ops. Não houve retorno de Times!";
                    }
                }
            }
            catch (Exception ex)
            {
                HttpContext.Session.SetString("NomeCampeonato", "");
                HttpContext.Session.SetString("IdCampeonato", "");
                ViewBag.error = "Ocorreu um erro inesperado. Erro:" + ex.Message;
            }
            return ReturnView("Times", viewModel);
        }

        [Route("Partidas")]
        public IActionResult Partidas()
        {
            MatchesCompleteViewModel viewModel = new MatchesCompleteViewModel();
            try
            {
                //string IdCampeonato = HttpContext.Session.GetString("IdCampeonato");
                SessionValid();
                if (!string.IsNullOrWhiteSpace(IdCampeonato))
                {
                    MatchesCompleteViewModel result = _campeonatoService.ListMatches(IdCampeonato);

                    if (result != null)
                    {
                        viewModel = result;
                        return View(viewModel);
                    }
                    else
                    {
                        ViewBag.error = "Ops. Não houve retorno de Times!";
                    }
                }
            }
            catch (Exception ex)
            {
                HttpContext.Session.SetString("NomeCampeonato", "");
                HttpContext.Session.SetString("IdCampeonato", "");
                ViewBag.error = "Ocorreu um erro inesperado. Erro:" + ex.Message;
            }
            return ReturnView("Partidas", viewModel);
        }
    }
}