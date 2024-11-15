using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace HoleParser
{
    public class Program
    {
        public static void Main()
        {
            int index = 0;

            // Path to the JSON file
            string filePath = "data.json";  // Make sure this is the correct path to your JSON file

            // Read JSON from file
            string jsonString = File.ReadAllText(filePath);

            // Parse JSON
            var jsonData = JsonSerializer.Deserialize<MyJsonData>(jsonString);

            // Deserialize the JSON string into a list of lists of doubles
            List<List<double>> data = JsonSerializer.Deserialize<List<List<double>>>(jsonData.Holes);

            var innerIndex = 0;

            // Print the result to verify
            foreach (var innerList in data)
            {
                innerIndex = 0;
                if(index==0)
                {
                    foreach(var charLocation in innerList)
                    {
                        Location location = (Location)charLocation;
                        Console.WriteLine($"Character {innerIndex + 1}: {location}");
                        innerIndex++;
                    }
                }
                else if (index == 1)
                {
                    foreach (var villagerLevel in innerList)
                    {
                        villagerName villagerName = (villagerName)innerIndex;
                        Console.WriteLine($"Villager {villagerName}: {villagerLevel}");
                        innerIndex++;
                    }
                }
                else if (index == 2)
                {
                    foreach (var villagerExp in innerList)
                    {
                        villagerName villagerName = (villagerName)innerIndex;
                        Console.WriteLine($"Exp For {villagerName}: {villagerExp}");
                        innerIndex++;
                    }
                }
                else if (index == 3)
                {
                    foreach (var opalsInvested in innerList)
                    {
                        villagerName villagerName = (villagerName)innerIndex;
                        Console.WriteLine($"Opals Invested For {villagerName}: {opalsInvested}");
                        innerIndex++;
                    }
                }
                else if (index == 4)
                {
                    foreach (var Magik in innerList)
                    {
                        holeMajik holeMajik = (holeMajik)innerIndex;
                        Console.WriteLine($"{holeMajik}: {Magik}");
                        innerIndex++;
                    }
                }
                else if (index == 5)
                {
                    foreach (var Majik in innerList)
                    {
                        villageMajik villageMajik = (villageMajik)innerIndex;
                        Console.WriteLine($"{villageMajik}: {Majik}");
                        innerIndex++;
                    }
                }
                else if (index == 6)
                {
                    foreach (var Majik in innerList)
                    {
                        idleonMajik idleonMajik = (idleonMajik)innerIndex;
                        Console.WriteLine($"{idleonMajik}: {Majik}");
                        innerIndex++;
                    }
                }
                else if (index == 7)
                {
                    foreach (var opalsFound in innerList)
                    {
                        Location location = (Location)innerIndex;
                        Console.WriteLine($"Opals Found In {location}: {opalsFound}");
                        innerIndex++;
                    }
                }
                else if (index == 8)
                {
                    foreach (var expansion in innerList)
                    {
                        Console.WriteLine($"Well Sediment {innerIndex+1} Expansion: {expansion}");
                        innerIndex++;
                    }
                }
                else if (index == 9)
                {
                    foreach (var wellSediment in innerList)
                    {
                        Console.WriteLine($"Well Sediment {innerIndex + 1} Expansion: {wellSediment}");
                        innerIndex++;
                    }
                }
                else if (index == 10)
                {
                    foreach (var bucketTarget in innerList)
                    {
                        Console.WriteLine($"Bucket {innerIndex + 1} Target: Well Sediment {bucketTarget}");
                        innerIndex++;
                    }
                }
                else if(index == 11)
                {
                    Console.WriteLine($"Ores Mined in Motherlode: {innerList[0]}");
                    Console.WriteLine($"Motherlode Layers Destroyed: {innerList[1]}");
                    Console.WriteLine($"Bugs Catched: {innerList[2]}");
                    Console.WriteLine($"Hive Layers Destroyed: {innerList[3]}");
                    Console.WriteLine($"Logs Chopped: {innerList[4]}");
                    Console.WriteLine($"Logs Layers Destroyed: {innerList[5]}");
                    Console.WriteLine($"Fish Catched: {innerList[4]}");
                    Console.WriteLine($"Fish Layers Destroyed: {innerList[5]}");
                    //Console.WriteLine($"???: Well Sediment {innerList[8]}");
                    //Console.WriteLine($"Ores Mined in Motherlode: Well Sediment {innerList[9]}");
                }
                else if (index == 12)
                {
                    Console.WriteLine($"Damage: {innerList[0]}");
                    Console.WriteLine($"Accuracy: {innerList[1]}");
                    Console.WriteLine($"Giant Scaling: {innerList[2]}");
                }
                else if (index == 13)
                {
                    foreach (var schematics in innerList)
                    {
                        Console.WriteLine($"Schematic {innerIndex + 1}: {(Unlocked)schematics}");
                        innerIndex++;
                    }
                }
                else if (index == 14)
                {
                    Console.WriteLine("Monument:");
                    Console.WriteLine($"Bravery Hours: {innerList[0]}");
                    Console.WriteLine($"Bravery Layers Broken: {innerList[1]}");
                }
                else if (index == 15)
                {
                    Console.WriteLine("Bravery Bonuses:");
                    //Console.WriteLine($"Bravery Hours: {innerList[0]}");
                    //Console.WriteLine($"Bravery Layers Broken: {innerList[1]}");
                }
                else if (index == 16)
                {
                    Console.WriteLine("Bell Improvement Method:");
                    //Console.WriteLine($"Bravery Hours: {innerList[0]}");
                    //Console.WriteLine($"Bravery Layers Broken: {innerList[1]}");
                }
                else if (index == 17)
                {
                    Console.WriteLine("Bell Ring Level:");
                    Console.WriteLine($"Bucket Fill Rate: {innerList[0]}");
                    Console.WriteLine($"Villager EXP: {innerList[1]}");
                    Console.WriteLine($"Harp Note: {innerList[2]}");
                    Console.WriteLine($"Daily Lamp Wishes: {innerList[3]}");
                }
                else if (index == 18)
                {
                    Console.WriteLine("Bell Charges:");
                    Console.WriteLine($"Ring Charges: {innerList[0]}");
                    Console.WriteLine($"Ring Uses: {innerList[1]}");
                    Console.WriteLine($"Ping Charges: {innerList[2]}");
                    Console.WriteLine($"Ping Uses: {innerList[3]}");
                    Console.WriteLine($"Clean Charges: {innerList[4]}");
                    Console.WriteLine($"Clean Uses: {innerList[5]}");
                    Console.WriteLine($"Renew Charges: {innerList[6]}");
                    Console.WriteLine($"Renew Uses: {innerList[7]}");
                }
                else if (index == 21)
                {
                    Console.WriteLine("Wishes Used:");
                    foreach (var wishesUsed in innerList)
                    {
                        Console.WriteLine($"Wishes {innerIndex + 1}: {wishesUsed}");
                        innerIndex++;
                    }
                }
                else if (index == 22)
                {
                    Console.WriteLine("Measurement Buff Levels:");
                    Console.WriteLine($"Village EXP: {innerList[0]}");
                    Console.WriteLine($"Bravery Sword Max Damage: {innerList[1]}");
                    Console.WriteLine($"Bell Ring and Ping Rate: {innerList[2]}");
                    Console.WriteLine($"Harp Note Gain: {innerList[3]}");
                    Console.WriteLine($"Daily Lamp wishes: {innerList[4]}");
                    Console.WriteLine($"Bucket Fill Rate: {innerList[5]}");
                    Console.WriteLine($"Harp EXP: {innerList[6]}");
                    Console.WriteLine($"Villager EXP: {innerList[7]}");
                    Console.WriteLine($"Harp Note Gain: {innerList[8]}");
                    Console.WriteLine($"MultiKill Per Tier: {innerList[9]}");
                }
                Console.WriteLine("=====================================================");
                index++;
            }
        }
    }

    public enum Location
    {
        NotInCavern = -1,
        Well = 0,
        Motherlode = 1,
        Den = 2,
        Bravery = 3,
        Bell = 4,
        Harp = 5,
        Lamp = 6,
        Hive = 7,
        Mushroom = 8,
        Justice = 9
    }

    public enum villagerName
    {
        Explorer = 0,
        Engineer = 1,
        Conjuror = 2,
        Measure = 3,
    }

    public enum holeMajik
    {
        MonumentalVibes = 0,
        StringisStrung = 1,
        WishyWashy = 2
    }

    public enum villageMajik
    {
        OpalEnthusiasm = 0,
        ContentedCreator = 1,
        CosmoEnhance = 2,
        Lengthmeister = 3
    }

    public enum idleonMajik
    {
        PocketDivinity = 0,
        BeegBeegForge = 1,
        ResourceBursting = 2,
        VoterIntegrity = 3,
        WeaponRelevancy = 4
    }

    public enum Unlocked
    {
        Locked = 0,
        Unlocked = 1
    }
}
