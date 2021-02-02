using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        string ModelList(string make, string model)
        {
            return make + model;
        }

        static void Main(string[] args)
        {
            var vehicle1 = new Car();
            var vehicle2 = new Car();
            var vehicle3 = new Car();

            List<string> ModelList = new List<string>();


            Console.WriteLine($"Howdy and welcome to Honest Abe's carlot!");

            vehicle1.Year = 1965;
            vehicle1.Make = "Ford";
            ModelList.Add(vehicle1.Make);
            vehicle1.Model = "Mustang";
            vehicle1.EngineNoise = "";
            vehicle1.HonkNoise = "Honk, honk";
            vehicle1.IsDriveable = false;
            vehicle1.IsLoud = true;
            vehicle1.MakeEngineNoise();
            vehicle1.MakeHonkNoise();
            
            vehicle2.Year = 1978;
            vehicle2.Make = "Volkswagen";
            ModelList.Add(vehicle2.Make);
            vehicle2.Model = "Super Beetle Convertible";
            vehicle2.EngineNoise = "Rrrrrrroom";
            vehicle2.HonkNoise = "Meep, meep";
            vehicle2.IsDriveable = true;
            vehicle2.IsLoud = true;
            vehicle2.MakeEngineNoise();
            vehicle2.MakeHonkNoise();

            vehicle3.Year = 2003;
            vehicle3.Make = "Toyota";
            ModelList.Add(vehicle3.Make);
            vehicle3.Model = "Prius";
            vehicle3.EngineNoise = "Purrrrrrr";
            vehicle3.HonkNoise = "Yeeeep";
            vehicle3.IsDriveable = true;
            vehicle3.IsLoud = false;
            vehicle3.MakeEngineNoise();
            vehicle3.MakeHonkNoise();


            Console.WriteLine("--------------------------");
            Console.WriteLine($"You're in luck, we have {ModelList.Count} models on the lot today!");

            foreach (var item in ModelList)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("Which one can I show you?");
        }
    }
}
