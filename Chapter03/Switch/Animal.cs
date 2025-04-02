using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03.SwitchSample
{
    public class Animal
    {
        public string? Name { get; set; }
        public DateTime Born { get; set; }
        public byte Legs { get; set; }
    }

    public class Cat: Animal 
    {
        public bool IsDomestic;
    }

    public class Spider : Animal
    {
        public bool IsPoisonous;
    }
}
