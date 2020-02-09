using AutoMapper;
using DraftSiteModels.Entities;
using DraftSiteModels.InputModels;
using DraftSiteModels.Models;
using DraftSiteModels.ViewModels;

namespace DraftSiteModels.Maps
{
    public class DraftSiteProfile : Profile
    {
        public DraftSiteProfile()
        {
            CreateMap<DraftSiteUser, DraftSiteUserViewModel>();
            CreateMap<Draft, DraftViewModel>();
            CreateMap<DraftInputModel, Draft>()
                .ForMember(destination => destination.PickTime, opts => opts.Ignore());
            CreateMap<DraftTime, DraftTimeViewModel>();
            
        }
    }
}
