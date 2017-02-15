using AutoMapper;
namespace ListerHaigh.Common
{
    public class AutoMapperHelper
    {
        public static void RegisterMappers() 
        {
            Mapper.Initialize(x => {
                x.AddProfile<EntityToModelProfile>();
            });
        }
    }
}
