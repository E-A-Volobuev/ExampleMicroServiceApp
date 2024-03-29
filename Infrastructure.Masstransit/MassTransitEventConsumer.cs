﻿using MassTransit;
using Services.Contracts;

namespace Infrastructure.Masstransit;

public sealed class MassTransitEventConsumer : IConsumer<MessageDto>
{
    public async Task Consume(ConsumeContext<MessageDto> context)
    {

        Console.WriteLine(context.Message.MessageText);
    }
}
