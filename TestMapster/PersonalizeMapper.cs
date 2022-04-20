
using Mapster;

namespace TestMapster
{
     static class PersonalizeMapper
    {
         public static void ConfigMapper()
        {
            TypeAdapterConfig<User, UserDto>
            .NewConfig()
            .Map(dest => dest.Nombre,
            src => src.Name);
        }
          
    }
}
