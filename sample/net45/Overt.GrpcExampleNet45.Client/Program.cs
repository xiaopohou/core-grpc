﻿//using Overt.GrpcExampleNet45.Client.Tracer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Overt.GrpcExample.Service.Grpc.GrpcExampleService;
using static Overt.GrpcExample.Service.Grpc.GrpcExampleService1;

namespace Overt.GrpcExampleNet45.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.A)
                    break;

                try
                {
                    var res = Overt.GrpcExample.Service.Grpc.ClientManager.Instance.Ask(new GrpcExample.Service.Grpc.AskRequest() { Key = "abc" });
                    Console.WriteLine("例子：" + res?.Content ?? "abc");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("异常");
                }

            } while (true);

            Console.WriteLine("结束...");
            Console.ReadLine();
        }
    }
}
