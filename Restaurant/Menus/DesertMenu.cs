using Restaurant.Foods.Desert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menus
{
    class DesertMenu
    {
        public List<Desert> desertList = new List<Desert>()
        {
            new Desert{Name="Lava Cake", Price=11.5},
            new Desert{Name="Icecream", Price=5.75},
        };

        public void Print()
        {
            var desertString = new StringBuilder(" ----- DESERT MENU ----- \n\n");
            for (int i = 0; i < desertList.Count; i++)
            {
                desertString.Append($"{i+1}. {desertList[i].Name} : {desertList[i].Price}$\n");
            }
            Console.WriteLine(desertString.ToString());
        }
    }
}
