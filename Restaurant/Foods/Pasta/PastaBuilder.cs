using Restaurant.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Foods.Pasta
{
    class PastaBuilder : IPastaBuilder
    {
        private Pasta _pasta = new Pasta();

        public PastaBuilder(string name)
        {
            PastaMenu pastaMenu = new PastaMenu();
            var list = pastaMenu.pastaList;

            for (int i = 0; i < list.Count; i++)
            {
                if (string.Equals(list[i].Name, name))
                {
                    _pasta.Name = list[i].Name;
                    _pasta.Price = list[i].Price;
                    _pasta.description = list[i].description;
                }
            }
        }
        public IPastaBuilder AddSauce(Sauce sauce)
        {
            _pasta.Sauce = sauce;
            _pasta.Price = _pasta.Price + 2.50;
            return this;
        }
        public double GetPrice()
        {
            return _pasta.Price;
        }
        public string PrintPasta()
        {
            return _pasta.PrintPasta();
        }
    }
}
