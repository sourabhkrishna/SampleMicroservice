//  ***********************************************************************
//  Assembly:  Sample_Microservice1.Domain
//
//  ***********************************************************************
//  <copyright file="WeatherForecasts.cs" company="Allegion, PLC">
//      Copyright (c) 2021 Allegion, PLC. All rights reserved.
//  </copyright>
//  <summary></summary>
//  ***********************************************************************
using System;

namespace Sample_Microservice1.Domain.Entities
{
    public class WeatherForecasts
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }
    }
}
