﻿using System.Text.Json;
using System.Text.Json.Serialization;
using Lecture216_ATMApp.Classes;
using Lecture216_ATMApp.Utils;

namespace Lecture216_ATMApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                ATM aTM = new();
                aTM.Run();
            }
        }
    }
}