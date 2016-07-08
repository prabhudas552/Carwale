using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace rabbitReceiver2
{
    public class Nat
    {
        public static void Main()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.ExchangeDeclare(exchange: "Steve", type: "topic");
                channel.ExchangeDeclare(exchange: "Steve", type: "topic");
                var rKey1 = "capAmerica";
                var rkey2 = "IronMan";
                channel.QueueDeclare(queue: "nat",
                                 durable: true,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);
               
                channel.QueueBind(queue: "nat",
                                  exchange: "Steve",
                                  routingKey: rKey1);

               

               
                channel.QueueBind(queue: "nat",
                                  exchange: "Tony",
                                  routingKey: rkey2);
                
                Console.WriteLine("Receiver Natasha:");

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    Console.WriteLine("Recieved: {0} ", message);
                };
                channel.BasicConsume(queue: "nat",
                                     noAck: true,
                                     consumer: consumer);
               

                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }
        }
    }
}
