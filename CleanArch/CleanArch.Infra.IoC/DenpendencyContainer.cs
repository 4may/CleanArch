using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.IoC
{
    public class DenpendencyContainer
    {
        /// <summary>
        /// DIに関するオブジェクトをまとめる。
        /// 具体的には、全てのプロジェクトの依存関係をIServiceCollectionに追加する
        /// </summary>
        /// <param name="services"></param>
        public static void ReigsterServices(IServiceCollection services) 
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
