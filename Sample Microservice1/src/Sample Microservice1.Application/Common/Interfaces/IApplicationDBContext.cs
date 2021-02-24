//  ***********************************************************************
//  Assembly:  Sample_Microservice1.Application
//
//  ***********************************************************************
//  <copyright file="IApplicationDBContext.cs" company="Allegion, PLC">
//      Copyright (c) 2021 Allegion, PLC. All rights reserved.
//  </copyright>
//  <summary></summary>
//  ***********************************************************************
using Microsoft.EntityFrameworkCore;
using Sample_Microservice1.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Sample_Microservice1.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<WeatherForecasts> WeatherForecasts { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
