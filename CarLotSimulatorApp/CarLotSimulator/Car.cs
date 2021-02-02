using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
        public bool IsLoud { get; set; }

        public void MakeEngineNoise()
        {
            if (IsDriveable && IsLoud == true)
            {
                Console.WriteLine($"The engine of our {Year} {Make} {Model} is so loud when it goes {EngineNoise}!");
            }

            else if (IsLoud != true)
            {
                Console.WriteLine($"But the engine of our {Year} {Make} {Model} is so quiet when it goes {EngineNoise}!");
            }
            
            else
            {
                Console.WriteLine($"I'm sorry to tell you, but the engine in our {Year} {Make} {Model} is dead! Maybe you want to look at different car?");
            }
            
        }

        public void MakeHonkNoise()
        {
            if (IsDriveable != true)
            {
                Console.WriteLine($"Even though this beauty isn't driveable, the horn still works and goes {HonkNoise}!");
            }

            else
            {
                Console.WriteLine($"You'll love this horn though. The {Year} {Make} {Model} is so funny when it goes {HonkNoise}!");
            }
            
        }
    }

}
