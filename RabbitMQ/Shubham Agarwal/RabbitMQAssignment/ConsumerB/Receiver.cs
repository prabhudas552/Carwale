using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerB
{
    public class Receiver
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("receiver-B");
            var factory = new ConnectionFactory() { HostName = "172.16.8.3" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                string queueName = "receiverB";
                channel.ExchangeDeclare(exchange: "sender", type: ExchangeType.Direct);
                channel.QueueDeclare(queueName, false, false, false, null);

                channel.QueueBind(queue: queueName, exchange: "sender", routingKey: "ProducerA");
                channel.QueueBind(queue: queueName, exchange: "sender", routingKey: "ProducerB");

                Console.WriteLine(" [*] Waiting for messages.");

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    var routingKey = ea.RoutingKey;
                    Console.WriteLine("Received: '{0}':'{1}'", routingKey, message);
                };
                channel.BasicConsume(queue: queueName, noAck: true, consumer: consumer);

                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }
        }
    }
}
