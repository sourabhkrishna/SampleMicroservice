//  ***********************************************************************
//  Assembly:  Sample_Microservice1.Application
//
//  ***********************************************************************
//  <copyright file="CreateWeatherForecastsCommandHandler.cs" company="Allegion, PLC">
//      Copyright (c) 2021 Allegion, PLC. All rights reserved.
//  </copyright>
//  <summary></summary>
//  ***********************************************************************
using MediatR;
using Sample_Microservice1.Application.Common.Interfaces;
using Sample_Microservice1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sample_Microservice1.Application.Commands.CreateWeatherForecasts
{
    public class CreateWeatherForecastsCommandHandler : IRequestHandler<CreateWeatherForecastsCommand, WeatherForecasts>
    {
        private readonly IApplicationDbContext _context;
        private static readonly string[] Summaries = new[]
             {
                   "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
             };

        public CreateWeatherForecastsCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<WeatherForecasts> Handle(CreateWeatherForecastsCommand request, CancellationToken cancellationToken)
        {
#pragma warning disable SecurityIntelliSenseCS // MS Security rules violation
            var rng = new Random();
#pragma warning restore SecurityIntelliSenseCS // MS Security rules violation
            var entity = new WeatherForecasts();

            entity.TemperatureC = request.TemperatureC;
            entity.Date = DateTime.UtcNow;
            entity.Summary = Summaries[rng.Next(Summaries.Length)];

            await _context.WeatherForecasts.AddAsync(entity, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);

            return entity;
        }

    }

}
