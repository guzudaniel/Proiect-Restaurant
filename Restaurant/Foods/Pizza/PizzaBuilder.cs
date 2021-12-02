using Restaurant.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Foods.Pizza
{
    class PizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public PizzaBuilder(string name)
        {
            PizzaMenu pizzaMenu = new PizzaMenu();
            var list = pizzaMenu.pizzaList;
            
            for (int i = 0; i < list.Count; i++)
            {
                if (string.Equals(list[i].Name, name))
                {
                    _pizza.Name = list[i].Name;
                    _pizza.Price = list[i].Price;
                    _pizza.description = list[i].description;
                }
            }
        }

        public IPizzaBuilder AddCheeseEdge()
        {
            _pizza.CheeseEdge = true;
            _pizza.Price = _pizza.Price + 3.00;
            return this;
        }

        public IPizzaBuilder AddSpicy()
        {
            _pizza.Spicy = true;
            _pizza.Price = _pizza.Price + 2.50;
            return this;
        }

        public IPizzaBuilder AddType(PizzaType type)
        {
            _pizza.Type = type;
            if(type == PizzaType.BIG)
                _pizza.Price = _pizza.Price + 5.00;
            else
            if(type == PizzaType.SMALL)
                _pizza.Price = _pizza.Price - 3.00;

            return this;
        }

        public double GetPrice()
        {
            return _pizza.Price;
        }

        public string Print() {

            return _pizza.PrintPizza();    
        }

    }
}
