//  ***********************************************************************
//  Assembly:  Sample_Microservice1.Application
//
//  ***********************************************************************
//  <copyright file="GetWeatherForecastsQueryHandler.cs" company="Allegion, PLC">
//      Copyright (c) 2021 Allegion, PLC. All rights reserved.
//  </copyright>
//  <summary></summary>
//  ***********************************************************************
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Sample_Microservice1.Application.Common.Interfaces;
using Sample_Microservice1.Application.Common.Models;
using Sample_Microservice1.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Sample_Microservice1.Application.Queries.GetWeatherForecasts
{
    public class GetWeatherForecastsQueryHandler : IRequestHandler<GetWeatherForecastsQuery, IEnumerable<WeatherForecastsModel>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetWeatherForecastsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<WeatherForecastsModel>> Handle(GetWeatherForecastsQuery request, CancellationToken cancellationToken)
        {
            return await _context.WeatherForecasts
                   .ProjectTo<WeatherForecastsModel>(_mapper.ConfigurationProvider)
                   .OrderBy(t => t.Date)
                   .ToListAsync(cancellationToken);
        }
    }
}
