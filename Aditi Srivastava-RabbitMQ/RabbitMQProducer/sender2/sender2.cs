using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace sender2
{
    public class Tony
    {
        public static int Main()
        {
            ConnectionFactory factory = new ConnectionFactory();
            factory.HostName = "localhost";


            using (var connection = factory.CreateConnection())

            using (var channel = connection.CreateModel())
            {
                Console.WriteLine("Sender Tony Stark");

                channel.ExchangeDeclare(exchange: "Tony", type: "topic");
               
                while (true)
                {
                    var message = (Console.ReadLine());
                    if (message == null)
                        message = "nothing";
                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "Tony",
                                         
                                         routingKey: "IronMan",
                                         basicProperties: null,
                                         body: body);
                    Console.WriteLine(" [x] Sent {0}", message);
                }
            }

        }

    }
}
