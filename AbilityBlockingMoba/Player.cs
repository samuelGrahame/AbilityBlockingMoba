using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityBlockingMoba
{
    public class Player : LivingEntity
    {
        public string Name;        

        public Ability Passive;

        public Ability MinorAbility1;
        public Ability MinorAbility2;
        public Ability MinorAbility3;
        public Ability MajorAbility;

        public Ability GameAbility1;
        public Ability GameAbility2;
        
        public Wearable Item1;
        public Wearable Item2;
        public Wearable Item3;
        public Trinket Item4;
        public Wearable Item5;
        public Wearable Item6;
        public Wearable Item7;
    }
}
