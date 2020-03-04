using AutoMapper;
using DraftSiteModels.DraftSiteModels;
using DraftSiteModels.Entities;
using DraftSiteModels.InputModels;
using DraftSiteModels.ViewModels;

namespace DraftSiteModels.Maps
{
    public class DraftSiteProfile : Profile
    {
        public DraftSiteProfile()
        {
            CreateMap<Users, DraftSiteUserViewModel>();

            CreateMap<MultiplayerDraft, DraftViewModel>()
                .ForMember(destination => destination.Username, opts => opts.MapFrom(source => source.Owner.Username))
                .ForMember(destination => destination.DraftStatus, opts => opts.MapFrom(source => source.DraftStatus.Value))
                .ForMember(destination => destination.PickTime, opts => opts.MapFrom(source => source.PickTime.Value));

            CreateMap<MultiplayerDraft, PreDraftViewModel>();

            CreateMap<DraftInputModel, MultiplayerDraft>()
                .ForMember(destination => destination.PickTime, opts => opts.Ignore())
                .ForMember(destination => destination.DraftStartType, opts => opts.Ignore());

            CreateMap<DraftTime, DraftTimeViewModel>();

            CreateMap<DraftStartType, DraftStartTypeViewModel>();

            CreateMap<DraftStatus, DraftStatusViewModel>();

            CreateMap<Players, DraftPlayerViewModel>()
                .ForMember(destination => destination.PlayerName, opts => opts.MapFrom(source => $"{source.Lastname}, {source.Firstname}"));

            CreateMap<Teams, DraftTeamSummaryViewModel>()
                .ForMember(destination => destination.TeamName, opts => opts.MapFrom(source => $"{source.Name}"));

            CreateMap<TeamChoiceInputModel, DraftTeamUser>()
                .ForMember(destination => destination.TeamsId, opts => opts.MapFrom(source => source.TeamName));

            CreateMap<DraftTeamUser, DraftTeamSummaryViewModel>()
                .ForMember(destination => destination.TeamName, opts => opts.MapFrom(source => source.Team.Name))
                .ForMember(destination => destination.TeamOwnerUser, opts => opts.MapFrom(source => source.User.Username));

            CreateMap<DraftTeamUserPlayer, DraftPlayerViewModel>()
                .ForMember(destination => destination.PlayerName, opts => opts.MapFrom(source => $"{source.Player.Lastname}, {source.Player.Firstname}"));

            CreateMap<Teams, DraftTeamUser>()
                .ForMember(destination => destination.TeamsId, opts => opts.MapFrom(source => source.Id))
                .ForMember(destination => destination.Id, opts => opts.Ignore());

            CreateMap<Players, DraftTeamUserPlayer>()
                .ForMember(destination => destination.PlayerId, opts => opts.MapFrom(source => source.Id));
        }
    }
}
