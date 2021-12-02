using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Foods.Meat
{
    class Meat : Food
    {
        public CookedType Type { get; set; } = CookedType.WELL;
        public SideDish SideDish { get; set; }
        public Sauce Sauce { get; set; }

        public string PrintMeat()
        {
            var meatString = new StringBuilder($"Meat {Name} : {Price}$ \n (");

            meatString.Append($"{Name}, {SideDish}, {Sauce}, Cooked {Type})");

            return meatString.ToString();
        }


    }
        
}
