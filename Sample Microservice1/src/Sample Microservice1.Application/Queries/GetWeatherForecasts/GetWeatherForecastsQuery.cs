//  ***********************************************************************
//  Assembly:  Sample_Microservice1.Application
//
//  ***********************************************************************
//  <copyright file="GetWeatherForecastsQuery.cs" company="Allegion, PLC">
//      Copyright (c) 2021 Allegion, PLC. All rights reserved.
//  </copyright>
//  <summary></summary>
//  ***********************************************************************
using MediatR;
using Sample_Microservice1.Application.Common.Models;
using System.Collections.Generic;

namespace Sample_Microservice1.Application.Queries.GetWeatherForecasts
{
    public class GetWeatherForecastsQuery : IRequest<IEnumerable<WeatherForecastsModel>>
    {

    }
}
