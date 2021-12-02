using Restaurant.Foods.Meat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menus
{
    class MeatMenu
    {
        public List<Meat> meatList = new List<Meat>()
        {
            new Meat{ Name = "Chicken", Price = 12.50},
            new Meat{ Name = "Duck", Price = 15.00},
            new Meat{ Name = "Steack", Price = 18.00},
            new Meat{ Name = "Pork chops", Price = 16.20},
            new Meat{ Name = "Hamburger", Price = 8.00}
        };

        public void Print()
        {
            var meatString = new StringBuilder(" ----- MEAT MENU ----- \n\n");
            for( int i = 0; i < meatList.Count; i++)
            {
                meatString.Append($"{i+1}. {meatList[i].Name} : {meatList[i].Price}$ \n");
            }
            Console.WriteLine(meatString.ToString());
        }
    }
}
