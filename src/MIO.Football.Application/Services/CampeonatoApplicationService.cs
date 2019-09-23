using AutoMapper;
using MIO.Football.Application.Interfaces;
using MIO.Football.Application.ViewModel.Campeonato;
using MIO.Football.Application.ViewModel.Matches;
using MIO.Football.Application.ViewModel.Standings;
using MIO.Football.Application.ViewModel.Team;
using MIO.Football.Domain.Interfaces.IServices;
using System;
using System.Collections.Generic;

namespace MIO.Football.Application.Services
{
    public class CampeonatoApplicationService : ICampeonatoApplicationService
    {
        private readonly ICampeonatoService _campeonatoService;
        private readonly IMapper _mapper;
        public CampeonatoApplicationService(ICampeonatoService campeonatoService, IMapper mapper)
        {
            _campeonatoService = campeonatoService;
            _mapper = mapper;
        }
        public MatchesCompleteViewModel ListMatches(string Code)
        {
            var result = _campeonatoService.ListMatches(Code);
            result.Wait();
            if (result.IsCompletedSuccessfully)
            {
                return _mapper.Map<MatchesCompleteViewModel>(result.Result);
            }

            return new MatchesCompleteViewModel();
        }

        public TeamCompleteViewModel ListTeams(string Code)
        {
            var result = _campeonatoService.ListTeams(Code);
            result.Wait();

            if (result.IsCompletedSuccessfully)
            {
                return _mapper.Map<TeamCompleteViewModel>(result.Result);
            }

            return new TeamCompleteViewModel();
        }

        public CampeonatoViewModel SearchCompetitions(string Code)
        {
            var result = _campeonatoService.SearchCompetitions(Code);
            result.Wait();

            if (result.IsCompletedSuccessfully)
            {
                return _mapper.Map<CampeonatoViewModel>(result.Result);
            }

            return new CampeonatoViewModel();
        }

        public StandingsEntityViewModel SearchStandings(string Code)
        {
            var result = _campeonatoService.SearchStandings(Code);
            result.Wait();
            StandingsEntityViewModel m = new StandingsEntityViewModel();
            try
            {
                if (result.IsCompletedSuccessfully)
                {
                    var dt = result.Result.standings[0].table[0].team;
                    List<TableTeamViewModel> lista = new List<TableTeamViewModel>();
                    foreach (var gr in result.Result.standings[0].table)
                    {
                        lista.Add(_mapper.Map<TableTeamViewModel>(gr));
                    }
                    var d = result.Result.standings;
                    var dmap = _mapper.Map<List<StandingsBaseViewModel>>(d);
                    var dm = _mapper.Map<List<TableTeamViewModel>>(result.Result.standings[0].table);
                    m = _mapper.Map<StandingsEntityViewModel>(result.Result);
                    m.standings.Add(new StandingsBaseViewModel() { table = lista });
                }
            }
            catch (Exception ex)
            {

            }
            return m;
        }
    }
}