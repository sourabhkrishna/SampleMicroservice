//  ***********************************************************************
//  Assembly:  Sample_Microservice1.Infrastructure
//
//  ***********************************************************************
//  <copyright file="WeatherForecastsConfig.cs" company="Allegion, PLC">
//      Copyright (c) 2021 Allegion, PLC. All rights reserved.
//  </copyright>
//  <summary></summary>
//  ***********************************************************************
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample_Microservice1.Domain.Entities;

namespace Sample_Microservice1.Infrastructure.Datebase
{
    class WeatherForecastsConfig : IEntityTypeConfiguration<WeatherForecasts>
    {
        public void Configure(EntityTypeBuilder<WeatherForecasts> builder)
        {

            builder.Property(t => t.Date).IsRequired();
            builder.Property(t => t.Summary).HasMaxLength(100).IsRequired();
            builder.Property(t => t.TemperatureC).IsRequired();
        }
    }
}
