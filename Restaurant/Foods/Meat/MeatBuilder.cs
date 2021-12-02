using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Foods.Meat
{
    class MeatBuilder : IMeatBuilder
    {
        private Meat _meat = new Meat();
        public IMeatBuilder AddCookedType(CookedType type)
        {
            _meat.Type = type;
            if (type == CookedType.WELL)
                _meat.Price = _meat.Price + 2.80;
            else
            if (type == CookedType.RARE)
                _meat.Price = _meat.Price - 1.50;

            return this;
        }

        public IMeatBuilder AddSauce(Sauce sauce)
        {
            _meat.Sauce = sauce;
            _meat.Price = _meat.Price + 2.50;
            return this;
        }

        public IMeatBuilder AddSideDish(SideDish sideDish)
        {
            _meat.SideDish = sideDish;
            
            switch(sideDish)
            {
                case SideDish.FrenchFries:
                 _meat.Price = _meat.Price + 4.80;
                break;
                case SideDish.MashedPotates:
                    _meat.Price = _meat.Price + 3.60;
                    break;
                case SideDish.Rice:
                    _meat.Price = _meat.Price + 3.20;
                    break;
                case SideDish.RoastPotates:
                    _meat.Price = _meat.Price + 5.00;
                    break;
            }
                
            return this;
        }

        public double GetPrice()
        {
            return _meat.Price;
        }
    }
}
