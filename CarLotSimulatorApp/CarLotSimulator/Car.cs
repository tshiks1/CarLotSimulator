﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Car
    {
        public string Make { get; set; }


        private int year;
        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                _ = year;
            }
        }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public bool IsDriveable { get; set; }
        public string HonkNoise { get; set; }

        public  void  MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine($"{Make} {Model}");
            Console.WriteLine(engineNoise);
        }
        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
            Console.WriteLine("  ");
        }
    }
}
