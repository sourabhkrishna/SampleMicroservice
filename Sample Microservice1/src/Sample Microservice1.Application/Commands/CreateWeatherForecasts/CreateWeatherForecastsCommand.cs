//  ***********************************************************************
//  Assembly:  Sample_Microservice1.Application
//
//  ***********************************************************************
//  <copyright file="CreateWeatherForecastsCommand.cs" company="Allegion, PLC">
//      Copyright (c) 2021 Allegion, PLC. All rights reserved.
//  </copyright>
//  <summary></summary>
//  ***********************************************************************
using MediatR;
using Sample_Microservice1.Domain.Entities;
using System.Collections.Generic;

namespace Sample_Microservice1.Application.Commands.CreateWeatherForecasts
{
    public class CreateWeatherForecastsCommand : IRequest<WeatherForecasts>
    {
        public int TemperatureC { get; set; }
    }
}
