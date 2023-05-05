using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ExeVetFix
{
    internal class Quarto
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Quarto(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
