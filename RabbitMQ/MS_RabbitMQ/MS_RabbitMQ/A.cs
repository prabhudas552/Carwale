using RabbitMQ.Client;
using System;
using System.Text;

namespace MS_RabbitMQ
{
    public class A
    {
       
        public static void Main()
        {
            var factory = new ConnectionFactory() { HostName = "172.16.8.3" };
           
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.ExchangeDeclare("A_tweets", "topic",false,false,null);
                    int count = 1;
                    
                    while (true)
                    {
                        string message = "A: Hi Rabbit " + count;
                        var body = Encoding.UTF8.GetBytes(message);

                        channel.BasicPublish("A_tweets", "tweets", null, body);
                        Console.WriteLine("{0} sent", message);
                        Console.ReadLine();
                        count += 1;
                    }
                }
            }
        }

    }
}
