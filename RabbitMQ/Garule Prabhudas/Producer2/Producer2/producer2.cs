using System;
using System.Linq;
using RabbitMQ.Client;
using System.Text;
namespace Producer2
{
    class producer2
    {
        public static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.ExchangeDeclare(exchange: "p2_exchange",
                                        type: "topic");

                var routingKey = "p2_key";
                var message = "Hello From P2";
                var body = Encoding.UTF8.GetBytes(message);
                Console.WriteLine(" Press any key to publish Message.");
                Console.ReadLine();
                channel.BasicPublish(exchange: "p2_exchange",
                                     routingKey: routingKey,
                                     basicProperties: null,
                                     body: body);
                Console.WriteLine(" [x] Sent '{0}':'{1}'", routingKey, message);
            }
            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}
