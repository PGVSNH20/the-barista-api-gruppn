using System;
using System.Collections.Generic;
using System.Linq;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCoffee = new CoffeeMaker().addBeans(19).addWater(1).ToBeverage();

            Console.WriteLine(newCoffee.GetType());

            foreach (string ingredient in newCoffee.Ingredients)
            {
                Console.WriteLine(ingredient);
            }

            var mochaCoffee = new CoffeeMaker().addBeans(5).addChocolateSyrup(20).addMilk(199).ToBeverage();
            Console.WriteLine(mochaCoffee.GetType());

            foreach (string ingredient in mochaCoffee.Ingredients)
            {
                Console.WriteLine(ingredient);
            }

            var customCoffee = new CoffeeMaker().addBeans(6).addChocolateSyrup(10).addMilk(7).addMilk(19).ToBeverage();

            Console.WriteLine(customCoffee.GetType());

            foreach (string ingredient in customCoffee.Ingredients)
            {
                Console.WriteLine(ingredient);
            }

            var list1 = new List<string>() { "test" };
            var list2 = new List<string>() { "test", "test2" };


            var firstNotSecond = list1.Except(list2).ToList();
            Console.WriteLine();
            foreach (var val in firstNotSecond)
            {
                Console.WriteLine(val);
            }

            //coffeeMaker.ToBeverage();

            // IBeverage espresso = new Espresso();

            //IBeverage espresso = new FluentEspresso()
            //                        .AddWater(20)
            //                        .AddBeans(new Bean()
            //                        {
            //                            AmountInG = 5,
            //                            Sort = CoffeSorts.Robusta
            //                        })
            //                        .Validate(e => e.Temerature > 90)
            //                    .ToBeverage();
            /* pseudo-code
            Espresso espresso = new Espresso().AddWater(20).AddBeans(b => b.AmountInG = 5 && b.Sort = CoffeSorts.Robusta).ToBravage();
            //espresso is type of Espresso

            Latte latte = new Espresso().AddWater(20).AddBeans(b => b.AmountInG = 7 && b.Sort = CoffeSorts.Robusta).AddMilk().ToBravage();
            //latte is type of Latte
             */
        }
    }
}
