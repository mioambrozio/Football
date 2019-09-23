using AutoMapper;
using MIO.Football.Application.ViewModel.Campeonato;
using MIO.Football.Application.ViewModel.Matches;
using MIO.Football.Application.ViewModel.Standings;
using MIO.Football.Application.ViewModel.Team;
using MIO.Football.Domain.Entities.Campeonato;
using MIO.Football.Domain.Entities.Matches;
using MIO.Football.Domain.Entities.Standings;
using MIO.Football.Domain.Entities.Team;
using System.Collections.Generic;

namespace MIO.Football.Application.AutoMapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<AreaViewModel, Area>();
            CreateMap<WinnerViewModel, Winner>();
            CreateMap<SeasonBaseViewModel, SeasonBase>();
            CreateMap<SeasonViewModel, Season>();
            CreateMap<TeamViewModel, Team>();
            CreateMap<CampeonatoEntityViewModel, CampeonatoEntity>();
            CreateMap<CampeonatoBaseViewModel, CampeonatoBase>();
            CreateMap<CampeonatoViewModel, Campeonato>();
            CreateMap<DetailTeamViewModel, DetailTeam>();
            CreateMap<FootbalTimeViewModel, FootbalTime>();
            CreateMap<PlayerViewModel, Player>();
            CreateMap<ScoreViewModel, Score>();
            CreateMap<TeamEntityViewModel, TeamEntity>();
            CreateMap<TeamCompleteViewModel, TeamComplete>();
            CreateMap<MatchesEntityViewModel, MatchesEntity>();
            CreateMap<MatchesCompleteViewModel, MatchesComplete>();
            CreateMap<TableTeamViewModel, TableTeam>();
            CreateMap<StandingsBaseViewModel, StandingsBase>();
            CreateMap<List<TeamViewModel>, List<Team>>();
            CreateMap<List<TableTeamViewModel>, List<TableTeam>>();
            CreateMap<List<StandingsBaseViewModel>, List<StandingsBase>>();
            CreateMap<StandingsEntityViewModel, StandingsEntity>();


            CreateMap<Area, AreaViewModel>();
            CreateMap<Winner, WinnerViewModel>();
            CreateMap<SeasonBase, SeasonBaseViewModel>();
            CreateMap<Season, SeasonViewModel>();
            CreateMap<Team, TeamViewModel>();
            CreateMap<CampeonatoEntity, CampeonatoEntityViewModel>();
            CreateMap<CampeonatoBase, CampeonatoBaseViewModel>();
            CreateMap<Campeonato, CampeonatoViewModel>();
            CreateMap<DetailTeam, DetailTeamViewModel>();
            CreateMap<FootbalTime, FootbalTimeViewModel>();
            CreateMap<Player, PlayerViewModel>();
            CreateMap<Score, ScoreViewModel>();
            CreateMap<TeamEntity, TeamEntityViewModel>();
            CreateMap<TeamComplete, TeamCompleteViewModel>();
            CreateMap<MatchesEntity, MatchesEntityViewModel>();
            CreateMap<MatchesComplete, MatchesCompleteViewModel>();
            CreateMap<TableTeam, TableTeamViewModel>();
            CreateMap<StandingsBase, StandingsBaseViewModel>();
            CreateMap<List<Team>, List<TeamViewModel>>();
            CreateMap<List<TableTeam>, List<TableTeamViewModel>>();
            CreateMap<List<StandingsBase>, List<StandingsBaseViewModel>>();
            CreateMap<StandingsEntity, StandingsEntityViewModel>();
        }
    }
}