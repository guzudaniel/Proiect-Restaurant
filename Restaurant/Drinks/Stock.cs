using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Drinks
{
    class Stock
    {
        private int lemon = 10;
        private int mint = 2;
        private int orange = 2;
        private int blueberry = 0;
        private int stawberry = 0;
        private int sugar = 5;
        private int salt = 2;

       private NaturalDrink _natural = new NaturalDrink();

        public string enable()
        {
            var s = new StringBuilder();

            ///for(int i = 0; i < _natural.ingredients.Count; i++)
           /// {
               
           /// }

            return s.ToString();
        }

    }
}
