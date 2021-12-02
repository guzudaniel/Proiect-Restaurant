using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Foods.Pizza
{
    public interface IPizzaBuilder
    {
        IPizzaBuilder AddSpicy();
        IPizzaBuilder AddCheeseEdge();
        IPizzaBuilder AddType(PizzaType type);
        double GetPrice();
        string Print();

    }
}
