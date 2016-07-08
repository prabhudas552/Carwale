using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace MS_RabbitMQ_B
{
    public class B
    {
        
        public static void Main()
        {
            var factory = new ConnectionFactory() { HostName = "172.16.8.3" };
            
            using (var connection = factory.CreateConnection())
            {
                {
                    using (var channel = connection.CreateModel())
                    {
                        channel.ExchangeDeclare("B_tweets", "topic", false, false, null);
                        
                        int count = 1;
                        while (true)
                        {
                            string message = "B : Hi Rabbit " + count;
                            var body = Encoding.UTF8.GetBytes(message);

                            channel.BasicPublish("B_tweets", "tweets", null, body);
                            Console.WriteLine("{0} sent", message);
                            Console.ReadLine();
                            count += 1;
                        }
                    }
                }
            }
        }
    }
}
