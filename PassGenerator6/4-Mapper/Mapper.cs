using AutoMapper;
using PassGenerator._3_Services;
using PassGenerator._3_Services.Interface;

namespace PassGenerator._4_Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<IPasswordGenService, PasswordGenService>();
        }
    }
}
