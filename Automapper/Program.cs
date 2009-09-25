using AutoMapper;

namespace Automapper
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Mapper.CreateMap<Customer, CustomerDto>()
                .ForMember(d => d.FirstName, o => o.MapFrom(c => c.Name.FirstName))
                .ForMember(d => d.LastName, o => o.MapFrom(c => c.Name.LastName))
                .ForMember(d => d.Name, o => o.MapFrom(c => c.Name.ToString()));


        }
    }
}