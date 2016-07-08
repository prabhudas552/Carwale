﻿using System;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace Receiver1
{
    class receiver1
    {
        public static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.ExchangeDeclare(exchange: "p1_exchange", type: "topic");
                //var queueName = channel.QueueDeclare().QueueName;

                channel.QueueDeclare(queue: "queue_c1",durable: false,exclusive: false,autoDelete: false,arguments: null);
                channel.QueueBind(queue: "queue_c1", exchange: "p1_exchange", routingKey: "p1_key");
               Console.WriteLine(" [*] Waiting for messages. To exit press CTRL+C");

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    var routingKey = ea.RoutingKey;
                    Console.WriteLine(" [x] Received '{0}':'{1}'",routingKey,message);
                };
                channel.BasicConsume(queue: "queue_c1", noAck: true,consumer: consumer);

                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }
        }
    }
}
