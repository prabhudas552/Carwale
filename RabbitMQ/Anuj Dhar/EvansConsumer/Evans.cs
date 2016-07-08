using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace EvansConsumer
{
    public class Evans
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "172.16.8.3" };

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    var queueEvans = channel.QueueDeclare().QueueName;
                    channel.QueueBind(queue: queueEvans,
                                      exchange: "MonyExchange",
                                      routingKey: "Mony");
                    channel.QueueBind(queue: queueEvans,
                                      exchange: "TonyExchange",
                                      routingKey: "Tony"); 

                    while (true)
                    {
                        var consumer = new EventingBasicConsumer(channel);
                        consumer.Received += (model, ea) =>
                        {
                            var body = ea.Body;
                            var message = Encoding.UTF8.GetString(body);
                            Console.WriteLine(" {0} : {1}", ea.RoutingKey, message);
                        };
                        channel.BasicConsume(queue: queueEvans,
                                             noAck: true,
                                             consumer: consumer);
                    }
                }
            }
        }
    }
}
