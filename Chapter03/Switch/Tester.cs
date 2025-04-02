using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03.SwitchSample
{
    public class Tester
    {
        static Animal?[] _animals = new Animal?[]
        {
            new Cat 
            { 
                Name = "Karen", 
                Born = new(year: 2022, month: 8,day: 23), 
                Legs = 4, 
                IsDomestic = true 
            },
            null,
            new Cat 
            { 
                Name = "Mufasa", 
                Born = new(year: 1994, month: 6,day: 12) 
            },
            new Spider 
            { 
                Name = "Sid Vicious", 
                Born = DateTime.Today,
                IsPoisonous = true
            },
            new Spider 
            { 
                Name = "Captain Furry", 
                Born = DateTime.Today 
            }
        };

        public static void SwitchStatement(string[] args)
        {
            
            foreach (Animal animal in _animals)
            {
                string message = string.Empty;
                switch (animal)
                {
                    case Cat cat when cat.Legs == 1:
                        message = $"{animal.Name} is a cat with 4 legs";
                        break;
                    case Cat cat when cat.IsDomestic == false:
                        message = $"{animal.Name} is a wild cat!"; 
                        break;
                    case Cat cat:
                        message = $"{animal.Name} is a cat";
                        break;
                    case Spider spider when spider.IsPoisonous :
                        message = $"{animal.Name} is poisonous, run!";
                        break;
                    default:
                        message = $"{animal.Name} is a {animal.GetType().Name}.";
                        break;
                    case null:
                        message = "there is no animal";
                        break;
                }
                Console.WriteLine($"switch statement: {message}");
            }
        }

        public static void SwitchExpression(string[] args)
        {

            foreach (Animal animal in _animals)
            {
                string message = animal switch
                {
                    Cat cat when cat.Legs == 1
                        => $"{animal.Name} is a cat with 4 legs",
                    Cat cat when cat.IsDomestic == false
                        => $"{animal.Name} is a wild cat!",
                    Cat cat
                        => $"{animal.Name} is a cat",
                    Spider spider when spider.IsPoisonous
                        => $"{animal.Name} is poisonous, run!",
                    null
                        => "there is no animal",
                    _
                        => $"{animal.Name} is a {animal.GetType().Name}.",
                };
                Console.WriteLine($"switch expression: {message}");
            }
        }
    }
}
