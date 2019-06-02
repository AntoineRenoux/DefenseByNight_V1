using AutoMapper;
using DAL.Mapping;
using DefenseByNight.Mapping;

namespace DefenseByNight.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(x => {

                #region Traduction
                x.AddProfile<TraductionEntityToDtoProfile>();
                #endregion

                #region User
                x.AddProfile<UserVmToDtoProfile>();
                x.AddProfile<UserEntityToDtoProfile>();
                #endregion

                x.AddProfile<DisciplineVmToDtoProfile>();
                x.AddProfile<FocusVmToDtoProfile>();
                x.AddProfile<PowerVmToDtoProfile>(); 
            });
        }
    }
}