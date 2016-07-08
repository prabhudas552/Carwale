using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace UserRavi
{
    public class Ravi
    {
        public void ReadMessage()
        {
            var factory = new ConnectionFactory() { HostName = "172.16.8.3" };
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    var queueName = channel.QueueDeclare().QueueName;

                    channel.QueueBind(queue: queueName,
                                     exchange: "ExchangeMessi",
                                     routingKey: "messi");
                    channel.QueueBind(queue: queueName,
                                     exchange: "ExchangeNeymar",
                                     routingKey: "neymar");

                    Console.WriteLine(" [*] Waiting for messages. To exit press CTRL+C");
            
                    while (true)
                    {
                        var consumer = new EventingBasicConsumer(channel);
                        consumer.Received += (model, ea) =>
                        {
                            var body = ea.Body;
                            var message = Encoding.UTF8.GetString(body);
                            if (message.Equals("exit", StringComparison.InvariantCultureIgnoreCase))
                            {
                                message = "Went Offline";
                            }
                            var routingKey = ea.RoutingKey;
                            Console.WriteLine(" [x] Received '{0}':'{1}'",
                                              routingKey,
                                              message);
                        };
                        channel.BasicConsume(queue: queueName,
                                             noAck: true,
                                             consumer: consumer);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Ravi..!!\n Press ENTER to begin...");
            Console.ReadLine();
            new Ravi().ReadMessage();
        }

    }
}
