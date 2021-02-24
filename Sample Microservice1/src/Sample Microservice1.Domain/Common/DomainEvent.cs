//  ***********************************************************************
//  Assembly:  Sample_Microservice1.Domain
//
//  ***********************************************************************
//  <copyright file="DomainEvent.cs" company="Allegion, PLC">
//      Copyright (c) 2021 Allegion, PLC. All rights reserved.
//  </copyright>
//  <summary></summary>
//  ***********************************************************************
using CloudNative.CloudEvents;
using MediatR;
using System;

namespace Sample_Microservice1.Domain.Common
{
    public abstract class DomainEvent : CloudEvent, INotification
    {
        protected DomainEvent(string type, Uri source, string id = null, DateTime? time = null, params ICloudEventExtension[] extensions) : base(type, source, id, time, extensions)
        {
        }
    }
}
