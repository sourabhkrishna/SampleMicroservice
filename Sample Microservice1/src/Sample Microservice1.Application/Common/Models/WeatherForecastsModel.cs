//  ***********************************************************************
//  Assembly:  Sample_Microservice1.Application
//
//  ***********************************************************************
//  <copyright file="WeatherForecastsModel.cs" company="Allegion, PLC">
//      Copyright (c) 2021 Allegion, PLC. All rights reserved.
//  </copyright>
//  <summary></summary>
//  ***********************************************************************
using System;

namespace Sample_Microservice1.Application.Common.Models
{
    public class WeatherForecastsModel
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
