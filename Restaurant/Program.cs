using System;
using System.Collections.Generic;
using Restaurant.Foods;
using Restaurant.Foods.Pizza;
using Restaurant.Foods.Pasta;
using Restaurant.Menus;
using Restaurant.Drinks;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaMenu = new PizzaMenu();
            var pastaMenu = new PastaMenu();
            var meatMenu = new MeatMenu();
            var desertMenu = new DesertMenu();
            var drinkMenu = new DrinkMenu();

            pizzaMenu.Print();
            pastaMenu.Print();
            meatMenu.Print();
            desertMenu.Print();
            drinkMenu.Print();

            ///clientul
   
            var capricioasa = new PizzaBuilder("Capricioasa")
                                            .AddCheeseEdge()
                                            .AddType(PizzaType.BIG)
                                            .AddSpicy();

            var carbonara = new PastaBuilder("Carbonara")
                                   .AddSauce(Sauce.Mayo);
            var coca = new SodaDrink();

            Console.WriteLine("Ce a comandat clientul costa:");
            Console.WriteLine(carbonara.GetPrice() + capricioasa.GetPrice() + coca.Price);



           
        }
    }
}
