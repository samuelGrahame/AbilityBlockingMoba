using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityBlockingMoba
{
    public class LivingEntity : Entity
    {
        public decimal Gold;
        public Health Life;
        public TeamType Team;

        public Stat Attack;
        public Stat Strength;
        public Stat Defence;

        public Stat Range;
        public Stat Magic;
    }
}
