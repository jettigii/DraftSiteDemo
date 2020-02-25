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
                .ForMember(destination => destination.PickTime, opts => opts.MapFrom(source => source.PickTime.Value))
                .ForMember(destination => destination.DraftStartType, opts => opts.MapFrom(source => source.PickTime.Value));

            CreateMap<MultiplayerDraft, PreDraftViewModel>();

            CreateMap<DraftInputModel, MultiplayerDraft>()
                .ForMember(destination => destination.PickTime, opts => opts.Ignore());

            CreateMap<DraftTime, DraftTimeViewModel>();

            CreateMap<DraftStartType, DraftStartTypeViewModel>();            

            CreateMap<DraftStatus, DraftStatusViewModel>();

            CreateMap<Players, DraftPlayerViewModel>()
                .ForMember(destination => destination.PlayerName, opts => opts.MapFrom(source => $"{source.Lastname}, {source.Firstname}"));

            CreateMap<Teams, DraftTeamSummaryViewModel>()
                .ForMember(destination => destination.TeamName, opts => opts.MapFrom(source => $"{source.Name}"));

            CreateMap<TeamChoiceInputModel, DraftTeamUser>()
                .ForMember(destination => destination.MultiPlayerDraftId, opts => opts.MapFrom(source => source.DraftId))
                .ForMember(destination => destination.TeamId, opts => opts.MapFrom(source => source.TeamId));

            CreateMap<DraftTeamUser, DraftTeamSummaryViewModel>();

            CreateMap<Teams, DraftTeamSummaryViewModel>();
            CreateMap<Teams, DraftTeamUser>()
                .ForMember(destination => destination.TeamId, opts => opts.MapFrom(source => source.Id))
                .ForMember(destination => destination.Id, opts => opts.Ignore());

            CreateMap<Players, DraftPlayerViewModel>();
            CreateMap<Players, DraftTeamUserPlayer>()
                .ForMember(destination => destination.PlayerId, opts => opts.MapFrom(source => source.Id));
        }
    }
}
