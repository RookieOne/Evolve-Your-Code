using AutoMapper;

namespace FluentInterfaces.Automapper
{
    public class AutoMapperExample
    {
        public void Example()
        {
            Mapper.CreateMap<Customer, CustomerDto>()
                .ForMember(d => d.FirstName, o => o.MapFrom(c => c.Name.FirstName))
                .ForMember(d => d.LastName, o => o.MapFrom(c => c.Name.LastName))
                .ForMember(d => d.Name, o => o.MapFrom(c => c.Name.ToString()));
        }
    }
}