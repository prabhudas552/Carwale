using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace AndersConsumer
{
    public class Anders
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "172.16.8.3" };

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    var queueAnders = channel.QueueDeclare().QueueName;
                    channel.QueueBind(queue: queueAnders,
                                      exchange: /*"TonyExchange"*/"ExchangeMessi",
                                      routingKey: /*"Tony"*/"messi"); 

                    while (true)
                    {
                        var consumer = new EventingBasicConsumer(channel);
                        consumer.Received += (model, ea) =>
                        {
                            var body = ea.Body;
                            var message = Encoding.UTF8.GetString(body);
                            Console.WriteLine(" {0} : {1}", ea.RoutingKey, message);
                        };
                        channel.BasicConsume(queue: queueAnders,
                                             noAck: true,
                                             consumer: consumer);
                    }
                }
            }
        }
    }
}
