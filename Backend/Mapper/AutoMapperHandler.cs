using Shared;
using AutoMapper;
namespace Backend.Mapper
{
    public class AutoMapperHandler: Profile
    {

        public AutoMapperHandler() 
        { 
            
            CreateMap<Order, OrderDto> (); 
        }
    }
}
