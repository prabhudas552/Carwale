using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Receiver1
{
    public class Bucky
    {
        public static void Main()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.ExchangeDeclare(exchange: "Steve", type: "topic");

                var queueName = channel.QueueDeclare(queue: "bucky",
                                 durable: true,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);
                
                channel.QueueBind(queue: "bucky",
                                  exchange: "Steve",
                                  routingKey: "capAmerica");

                Console.WriteLine("Receiver Bucky");

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    Console.WriteLine("Received: {0}", message);
                };
                channel.BasicConsume(queue: "bucky",
                                     noAck: true,
                                     consumer: consumer);

                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }
        }
    }
}

