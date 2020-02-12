using AutoMapper;
using DraftSiteModels.Entities;
using DraftSiteModels.InputModels;
using DraftSiteModels.ViewModels;

namespace DraftSiteModels.Maps
{
    public class DraftSiteProfile : Profile
    {
        public DraftSiteProfile()
        {
            CreateMap<DraftSiteUser, DraftSiteUserViewModel>();

            CreateMap<Draft, DraftViewModel>()
                .ForMember(destination => destination.Username, opts => opts.MapFrom(source => source.Owner.Username))
                .ForMember(destination => destination.DraftStatus, opts => opts.MapFrom(source => source.DraftStatus.Value))
                .ForMember(destination => destination.PickTime, opts => opts.MapFrom(source => source.PickTime.Value));

            CreateMap<Draft, PreDraftViewModel>();

            CreateMap<DraftInputModel, Draft>()
                .ForMember(destination => destination.PickTime, opts => opts.Ignore());

            CreateMap<DraftTime, DraftTimeViewModel>();

            CreateMap<DraftStatus, DraftStatusViewModel>();

        }
    }
}
