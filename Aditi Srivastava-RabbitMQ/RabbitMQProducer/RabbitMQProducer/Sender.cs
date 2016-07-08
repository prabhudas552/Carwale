using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;


namespace RabbitMQ
{
    public class Steve
    {
        public static int Main()
        {
            ConnectionFactory factory = new ConnectionFactory();
            factory.HostName = "localhost";


               using (var connection = factory.CreateConnection())

               using (var channel = connection.CreateModel())
               {
                   Console.WriteLine("Sender Steve Rogers");
                   channel.ExchangeDeclare(exchange: "Steve", type: "topic");
                   
                   while (true)
                   {
                       var message = (Console.ReadLine());
                       if (message == null)
                           message = "nothing";

                       var body = Encoding.UTF8.GetBytes(message);
                       
                       channel.BasicPublish(exchange: "Steve",
                                            routingKey: "capAmerica",
                                            basicProperties: null,
                                            body: body);
                       Console.WriteLine("Sent {0}", message);
                      
                   }
               }
             
                    }

      
    }
  
    }

