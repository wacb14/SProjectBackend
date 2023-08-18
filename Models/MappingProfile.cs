using AutoMapper;
using SProject.Models.ViewModels;

namespace SProject.Models{
    public class MappingProfile:Profile{
        public MappingProfile(){
            CreateMap<Item, VMItem>();
            CreateMap<VMItem, Item>();
        }
    }
}