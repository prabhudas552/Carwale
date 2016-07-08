using RabbitMQ.Client;
using System;
using System.Text;

namespace ProducerNeymar
{
    public class Neymar
    {
        public void StartConnection()
        {
            var factory = new ConnectionFactory() { HostName = "172.16.8.3" };
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    string routingKey = "neymar";
                    channel.ExchangeDeclare(exchange: "ExchangeNeymar",
                                        type: "topic");
                    channel.QueueDeclare(queue: "Queue_Brazil",
                                         durable: false,
                                         exclusive: false,
                                         autoDelete: false,
                                         arguments: null);
                    Console.WriteLine("Enter the message...");
                    while (true)
                    {
                        Console.Write(">> ");
                        string message = Console.ReadLine();
                        var body = Encoding.UTF8.GetBytes(message);

                        channel.BasicPublish(exchange: "ExchangeNeymar",
                                             routingKey: routingKey,
                                             basicProperties: null,
                                             body: body);
                        Console.WriteLine(" [x] Sent '{0}':'{1}'", routingKey, message);
                        if (message.Equals("exit", StringComparison.InvariantCultureIgnoreCase))
                            break;
                    }
                    Console.WriteLine("Adiós..!!\n Press ENTER to exit.");
                    Console.ReadKey();
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Neymar..!!\n Press ENTER to begin...");
            Console.ReadLine();
            new Neymar().StartConnection();
        }
    }

}