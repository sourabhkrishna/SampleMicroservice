//  ***********************************************************************
//  Assembly:  Sample_Microservice1.Application
//
//  ***********************************************************************
//  <copyright file="CreateWeatherForecastsCommandValidator.cs" company="Allegion, PLC">
//      Copyright (c) 2021 Allegion, PLC. All rights reserved.
//  </copyright>
//  <summary></summary>
//  ***********************************************************************
using FluentValidation;

namespace Sample_Microservice1.Application.Commands.CreateWeatherForecasts
{
    public class CreateWeatherForecastsCommandValidator : AbstractValidator<CreateWeatherForecastsCommand>
    {
        public CreateWeatherForecastsCommandValidator()
        {
            RuleFor(x => x.TemperatureC).NotNull().NotEmpty().GreaterThanOrEqualTo(-30).LessThanOrEqualTo(70);
        }
    }
}
