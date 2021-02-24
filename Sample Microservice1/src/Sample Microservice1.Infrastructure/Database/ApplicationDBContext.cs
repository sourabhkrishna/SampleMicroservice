//  ***********************************************************************
//  Assembly:  Sample_Microservice1.Infrastructure
//
//  ***********************************************************************
//  <copyright file="ApplicationDBContext.cs" company="Allegion, PLC">
//      Copyright (c) 2021 Allegion, PLC. All rights reserved.
//  </copyright>
//  <summary></summary>
//  ***********************************************************************
using Microsoft.EntityFrameworkCore;
using Sample_Microservice1.Application.Common.Interfaces;
using Sample_Microservice1.Domain.Entities;
using System.Reflection;

namespace Sample_Microservice1.Infrastructure.Database
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<WeatherForecasts> WeatherForecasts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
