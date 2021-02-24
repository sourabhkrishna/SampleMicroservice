//  ***********************************************************************
//  Assembly:  Sample_Microservice1.Api
//
//  ***********************************************************************
//  <copyright file="WeatherForecastController.cs" company="Allegion, PLC">
//      Copyright (c) 2021 Allegion, PLC. All rights reserved.
//  </copyright>
//  <summary></summary>
//  ***********************************************************************
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sample_Microservice1.Application.Commands.CreateWeatherForecasts;
using Sample_Microservice1.Application.Common.Models;
using Sample_Microservice1.Application.Queries.GetWeatherForecasts;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<WeatherForecastController> _logger;
        public WeatherForecastController(IMediator mediator, ILogger<WeatherForecastController> logger)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<IEnumerable<WeatherForecastsModel>>> Get()
        {
            return Ok(await _mediator.Send(new GetWeatherForecastsQuery()).ConfigureAwait(false));
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<WeatherForecastsModel>> Create(CreateWeatherForecastsCommand command)
        {
            return Ok(await _mediator.Send(command).ConfigureAwait(false));
        }

    }
}
