using Services.Contracts;

namespace Services.Abstractions;

public interface IMassTransitHelper
{
    /// <summary>
    /// отправка сообщения в очередь брокера сообщений
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    Task SendMessageAsync(MessageDto dto, string queue);
    /// <summary>
    /// получение сообщения
    /// </summary>
    /// <returns></returns>
    Task ReceiveMessageAsync(string queue);
}
