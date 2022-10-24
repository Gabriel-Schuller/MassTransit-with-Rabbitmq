using MassTransit;
using Model;

internal class OrderConsumer : IConsumer<Order>
{
    public async Task Consume(ConsumeContext<Order> context)
    {
        await Console.Out.WriteLineAsync($"Avem urmatorul nume din consumer: {context.Message.Name}");
    }
}