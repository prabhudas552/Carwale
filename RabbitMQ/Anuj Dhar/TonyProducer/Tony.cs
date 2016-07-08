using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;

namespace TonyProducer
{
    public class Tony
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "172.16.8.3"};

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.ExchangeDeclare(exchange: "TonyExchange", type: "topic");

                    while (true)
                    {
                        Console.Write(" Tony : ");
                        var message = Console.ReadLine();
                        var body = Encoding.UTF8.GetBytes(message);

                        channel.BasicPublish(exchange: "TonyExchange",
                                             routingKey: "Tony",
                                             basicProperties: null,
                                             body: body);
                    }
                    
                }
            }
        }
    }
}
