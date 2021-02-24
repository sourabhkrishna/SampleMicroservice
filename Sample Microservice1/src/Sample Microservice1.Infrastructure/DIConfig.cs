//  ***********************************************************************
//  Assembly:  Sample_Microservice1.Infrastructure
//
//  ***********************************************************************
//  <copyright file="DIConfig.cs" company="Allegion, PLC">
//      Copyright (c) 2021 Allegion, PLC. All rights reserved.
//  </copyright>
//  <summary></summary>
//  ***********************************************************************
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sample_Microservice1.Application.Common.Interfaces;
using Sample_Microservice1.Infrastructure.Database;

namespace Sample_Microservice1.Infrastructure
{
    public static class DIConfig
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseInMemoryDatabase("Sample_Microservice1_DB"));

            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());

            return services;
        }
    }
}
