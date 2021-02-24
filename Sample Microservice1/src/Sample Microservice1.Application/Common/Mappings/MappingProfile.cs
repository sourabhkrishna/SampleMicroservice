//  ***********************************************************************
//  Assembly:  Sample_Microservice1.Application
//
//  ***********************************************************************
//  <copyright file="MappingProfile.cs" company="Allegion, PLC">
//      Copyright (c) 2021 Allegion, PLC. All rights reserved.
//  </copyright>
//  <summary></summary>
//  ***********************************************************************
using AutoMapper;
using Sample_Microservice1.Application.Common.Models;
using Sample_Microservice1.Domain.Entities;

namespace Sample_Microservice1.Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<WeatherForecasts, WeatherForecastsModel>();
        }
    }
}
