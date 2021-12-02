using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Foods.Meat
{
     interface IMeatBuilder
    {
        IMeatBuilder AddCookedType(CookedType type);
        IMeatBuilder AddSideDish(SideDish sideDish);
        IMeatBuilder AddSauce(Sauce sauce);
        double GetPrice();
    }
}
