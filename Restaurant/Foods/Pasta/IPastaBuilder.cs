using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Foods.Pasta
{
    interface IPastaBuilder
    {
        IPastaBuilder AddSauce(Sauce sauce);
        double GetPrice();
        string PrintPasta();
    }
}
