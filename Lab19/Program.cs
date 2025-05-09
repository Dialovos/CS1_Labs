// Hoang Le
// hle2@northeaststate.edu
// Project 19

using Lab19;
using System;

namespace Lab18
{
    /// <summary>
    /// Lab19 Implementation
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //default constructor
            Television soni = new Television();
            Television senyo = new Television();

            soni.SetChannel(128);
            senyo.Channel = 256;

            for (int i = 0; i < 267835; i++)
            {
                soni.ChannelUp();
            }

            for (int i = 0; i < 12651; i++)
            {
                senyo.ChannelDown();
            }

            for (int i = 0; i < 55; i++)
            {
                soni.VolumeUp();
            }

            for (int i = 0; i < 2; i++)
            {
                senyo.VolumeDown();
            }

            Console.WriteLine($"soni {soni}");
            Console.WriteLine($"senyo {senyo}");
        }
    }
}