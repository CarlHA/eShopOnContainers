﻿using RabbitMQ.Client;
using System;

namespace Microsoft.eShopOnContainers.BuildingBlocks.EventBusRabbitMQ
{

    public interface IRabbitMQPersisterConnection
        : IDisposable
    {
        bool IsConnected { get; }

        bool TryConnect();

        IModel CreateModel();
    }
}
