using System;
using System.Net.Security;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace _30SerialziacjaDe
{
    class Program
    {
        static void Main(string[] args) 
        {
            // DeSerializacja
            string playerSerialized = File.ReadAllText(@"D:/ZapisDanychAzur/LearningPack/HouseOfMemory/Memory/30SerializacjaDe/Json.json)";
            Player player = JsonConvert.DeserializeObject<Player>(playerSerialized);
            Console.WriteLine(player.Name);

            // serializacja
            var player = new Player()
            {
                Name = "Mario",
                Level = 1,
                HealthPoints = 100,
                Statistics = new List<Statistics>()
                {
                    new Statistics()
                    {
                        Name = "Strength",
                        Points = 10
                    },
                    new Statistics() 
                    {
                        Name = "Intelligence",
                        Points = 10
                    }
                }
            };
            player.Level++;

            string playerSerialized = JsonConvert.SerializeObject(player);   // stringa moze nie być bo wcześniej zadeklarowałem bo się nie odpalii dzwońcu
            File.WriteAllText(@"D:/ZapisDanychAzur/LearningPack/HouseOfMemory/Memory/30SerializacjaDe/Json.json",playerSerialized);
        }
    }

}