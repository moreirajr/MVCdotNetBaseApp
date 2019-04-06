using AutoMapper;


namespace MVCdotNetBaseApp.Web.Helpers.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(config =>
            {
                config.AddProfile(new ViewModelToDomainProfile());
            });
        }
    }
}