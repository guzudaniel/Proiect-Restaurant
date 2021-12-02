using Restaurant.Foods.Pasta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menus
{
    class PastaMenu
    {
        public List<Pasta> pastaList = new List<Pasta>()
        {
            new Pasta{Name = "Carbonara", Price = 10, description ={"bacon","cheese","sour cream"}},
            new Pasta{Name = "Sea Food", Price = 18.5, description ={"mollusks","crabs","mussels", "oysters"}},
            new Pasta{Name = "Gnochi", Price = 12.5, description ={ "salami","egg","sour cream","cheese"}},
            new Pasta{Name = "Guattro formaggi", Price = 20, description ={ "milk","cheese","gorgonzola","fontina","parmesan","emmentaler","eggs"}}
        };

        public void Print()
        {
            Console.WriteLine(" ----- PASTA MENU ----- \n");
            for (int i = 0; i < pastaList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. " + pastaList[i].PrintPasta());
            }

        }
    }
}
