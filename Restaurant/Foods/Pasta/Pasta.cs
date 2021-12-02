using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Foods.Pasta
{
    class Pasta : Food
    {
        public Sauce Sauce { get; set; } = Sauce.Null;

        public List<string> description = new List<string>();

        public string PrintPasta()
        {
            var pastaString = new StringBuilder($"Pasta {Name} : {Price}$ \n (");

            for (int i = 0; i < description.Count; i++)
                pastaString.Append($"{description[i]}, ");
            pastaString.Remove(pastaString.Length - 2, 2);
            pastaString.Append($")\n");

            return pastaString.ToString();
        }

    }
}
