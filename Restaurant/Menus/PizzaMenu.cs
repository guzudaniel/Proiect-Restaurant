using Restaurant.Foods.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menus
{
    class PizzaMenu
    {
        public List<Pizza> pizzaList = new List<Pizza>()
        {
            new Pizza {Name="Capricioasa", Price=23, description={"salami","cheese","olive","corn"} },
            new Pizza {Name="Quattro stagioni", Price=24, description={"salami","cheese","olive","corn","mushrooms"}},
            new Pizza {Name="Cheese Bachus", Price=30, description={"salami","cheese","olive","corn","mushrooms","pepper"}},
            new Pizza {Name="Margherita", Price=15, description={"salami","cheese" }},
            new Pizza {Name="Prosciuto e funghi", Price=24, description={"salami","cheese","corn","pepper","olive"}},
            new Pizza {Name="Diabola", Price=20, description={"salami","corn","pepper"}},
            new Pizza {Name="Veggie Pizza", Price=28, description={"cheese","corn","mushrooms","pepper"}}
        };

        public void Print()
        {
            Console.WriteLine(" ----- PIZZA MENU ----- \n");
            for (int i = 0; i < pizzaList.Count; i++)
            {
                Console.WriteLine($"{i+1}. " + pizzaList[i].PrintPizza());
            }
        }
    }
}
