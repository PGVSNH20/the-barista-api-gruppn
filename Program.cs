using System;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Espresso espresso = new Espresso();


            espresso.addWater(125);
            espresso.addMilk(50);
            espresso.addBeans(new Beans()
            {
                BeanAmount = 5,
                BeanType = "Robusta"
            });

            espresso.val = (new Validate()
            {
                Temperature = 90,
            });


            espresso.ToBeverage();

            Latte latte = new Latte();

            latte.addMilk(100);
            espresso.addBeans(new Beans()
            {
                BeanAmount = 5,
                BeanType = "Robusta"
            });
            espresso.val = (new Validate()
            {
                Temperature = 80,
            });

            latte.ToBeverage();
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
/*
public interface IMammal
{
    int NumberOfLegs { get; }
    string Specie { get; }
    void MakeASound();
}


public class Dog : IMammal
{
    private int numberOfLegs = 4;
    private string specie = "Dogs";

    public int NumberOfLegs => numberOfLegs;

    public string Specie => specie;

    public void MakeASound()
    {
        Console.WriteLine("Wuf");
    }
}

public class Human : IMammal
{
    private int numberOfLegs = 2;
    private string specie = "Humans";
    private string quote;


    public Human(string quote)
    {
        this.quote = quote;
    }

    public int NumberOfLegs => numberOfLegs;

    public string Specie => specie;

    public void MakeASound()
    {
        Console.WriteLine(quote);
    }
}

class ExecuteAbstraction
{
    static void DisplayMammal(IMammal mammal)
    {
        Console.WriteLine($"{mammal.Specie} has {mammal.NumberOfLegs} legs");
        Console.Write($"The {mammal.Specie} say: ");
        mammal.MakeASound();
    }

    static void Main(string[] args)
    {
        DisplayMammal(new Dog());
        DisplayMammal(new Human("The Ultimate Answer to Life, The Universe and Everything is...42!"));
    }
}

*/