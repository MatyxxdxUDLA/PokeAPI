using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI.Models
{
    public class Abilities
    {
        public Ability ability { get; set; }
        public bool isHiden {  get; set; }
        public int slot { get; set; }
    }
}
