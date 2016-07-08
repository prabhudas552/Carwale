using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace MS_RabbitMQ_D
{
    public class D
    {
       
        public static void Main(string[] args)
        {
            Console.WriteLine("D Consumer");
            var factory = new ConnectionFactory() { HostName = "172.16.8.3" };
           
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.ExchangeDeclare("A_tweets", "topic", false, false, null);
                    channel.ExchangeDeclare("B_tweets", "topic", false, false, null);
                    channel.QueueDeclare("D_feed", false, false, false, null);
                    channel.QueueBind("D_feed", "A_tweets", "tweets");
                    channel.QueueBind("D_feed", "B_tweets", "tweets");


                    var consumer = new EventingBasicConsumer(channel);

                    consumer.Received += (model, ea) =>
                    {
                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body);
                        Console.WriteLine(" [x] Received {0}", message);
                        
                    };
                    channel.BasicConsume(queue: "D_feed",
                                         noAck: true,
                                         consumer: consumer);

                    Console.WriteLine(" Press [enter] to exit.");
                    Console.ReadLine();
                }
            }
        }
    }
}
