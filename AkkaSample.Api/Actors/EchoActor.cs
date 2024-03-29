﻿using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AkkaSample.Api.Actors
{
    public class EchoActor : UntypedActor
    {
        protected override void PreStart()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Starting this echo actor");
            Console.ResetColor();
        }

        protected override void OnReceive(object message)
        {
            if (message.ToString().ToLower().Contains("1"))
            {
                Thread.Sleep(1000);
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Message received by echo: {message}");
            Console.ResetColor();
        }
    }
}
