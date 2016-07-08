using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerB
{
    public class Sender
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sender-B");
            var factory = new ConnectionFactory() { HostName = "172.16.8.3" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.ExchangeDeclare(exchange: "sender", type: ExchangeType.Direct);

                string message = "Hello";
                Console.WriteLine(" Write \'exit\' to exit.");
                while (!message.Equals("exit"))
                {
                    var body = Encoding.UTF8.GetBytes(message);
                    channel.BasicPublish(exchange: "sender", routingKey: "ProducerB", basicProperties: null, body: body);
                    Console.WriteLine("Sent: '{0}'", message);
                    message = Console.ReadLine();
                }
            }
        }
    }
}
