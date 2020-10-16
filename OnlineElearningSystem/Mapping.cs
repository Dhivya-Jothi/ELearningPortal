using OnlineElearningSystem.Entity;
using OnlineElearningSystem.Models;

namespace OnlineElearningSystem
{
	public class Mapping
	{
		public static void MapTable()
		{
			AutoMapper.Mapper.Initialize(config =>
			{
				config.CreateMap<UserDetailModel, UserDetail>()
				.ForMember(dest=>dest.userRole,opt=>opt.MapFrom(src=>"User"));

				config.CreateMap<CategoryModel, Category>();
				config.CreateMap<CourseModel, Course>();
				config.CreateMap<TopicModel, Topic>();
				config.CreateMap<LinkModel, Link>();
			});

			
		}
	}
}