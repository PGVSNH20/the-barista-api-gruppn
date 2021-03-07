using System;
using System.Collections.Generic;

public interface IBeverage
{
    List<string> Ingredients { get; }
    string CupType { get; }
}

public interface ICoffeemaker
{
    ICoffeemaker addWater(int amount);

    ICoffeemaker addMilk(int amount);

    ICoffeemaker addMilkFoam(int amount);

    ICoffeemaker addChocolateSyrup(int amount);

    ICoffeemaker addBeans(int amount);

    IBeverage ToBeverage();
}

class CoffeeMaker : ICoffeemaker
{
    public int Water { get; set; }

    public int Milk { get; set; }

    public int MilkFoam { get; set; }

    public int ChocolateSyrup { get; set; }

    public int Temperature { get; set; }

    public int Beans { get; set; }

    public List<string> Ingredients = new List<string>();

    public ICoffeemaker addBeans(int amount)
    {
        Beans = amount;
        Ingredients.Add("Beans");
        Console.WriteLine("Lägger till bönor");

        return this;
    }

    public ICoffeemaker addWater(int amount)
    {
        Water = amount;
        Ingredients.Add("Water");
        Console.WriteLine("Lägger till vatten");

        return this;
    }

    public ICoffeemaker addMilk(int amount)
    {
        Milk = amount;
        Ingredients.Add("Milk");

        return this;
    }

    public ICoffeemaker addMilkFoam(int amount)
    {
        MilkFoam = amount;
        Ingredients.Add("Milk Foam");

        return this;
    }

    public ICoffeemaker addChocolateSyrup(int amount)
    {
        ChocolateSyrup = amount;
        Ingredients.Add("Chocolate Syrup");

        return this;
    }

    public ICoffeemaker addBeans()
    {
        return this;
    }

    public IBeverage ToBeverage()
    {
        if (Ingredients.Contains("Milk") && Ingredients.Contains("Chocolate Syrup"))
        {

            Console.WriteLine("Gör Mocha!");

            return new Mocha();
        }

        else if (Ingredients.Contains("Milk") && Ingredients.Contains("Milk Foam"))
        {

            Console.WriteLine("Gör Cappuccino!");

            return new Cappuccino();
        }

        else if (Ingredients.Contains("Milk Foam"))
        {

            Console.WriteLine("Gör Macchiato!");

            return new Macchiato();
        }

        else if (Ingredients.Contains("Water"))
        {

            Console.WriteLine("Gör Americano!");

            return new Americano();
        }
        
        else if (Ingredients.Contains("Milk"))
        {

            Console.WriteLine("Gör latte!");

            return new Latte();
        }

        return new CustomCoffee();
    }
}

class Validate
{
    public int Temperature { set; get; }

}

class Espresso : IBeverage
{

    public List<string> Ingredients => new List<string>() { "Beans" };

    public string CupType => throw new System.NotImplementedException();

}

class Latte : IBeverage
{

    public List<string> Ingredients => new List<string>() { "Milk" };
    public string CupType => throw new NotImplementedException();

}

class Cappuccino : IBeverage
{

    public List<string> Ingredients => new List<string>() { "Milk", "Milk Foam" };

    public string CupType => throw new NotImplementedException();
}

class Americano : IBeverage
{

    public List<string> Ingredients => new List<string>() { "Water" };

    public string CupType => throw new NotImplementedException();
}

class Macchiato : IBeverage
{

    public List<string> Ingredients => new List<string>() { "Milk Foam" };

    public string CupType => throw new NotImplementedException();
}

class Mocha : IBeverage
{

    public List<string> Ingredients => new List<string>() { "Milk", "Chocolate Syrup" };

    public string CupType => throw new NotImplementedException();
}


class CustomCoffee : IBeverage
{
    List<string> IBeverage.Ingredients => new List<string>() { "" };

    string IBeverage.CupType => throw new NotImplementedException();
}

//IBeverage espresso = new FluentEspresso()
//                        .AddWater(20)
//                        .AddBeans(new Bean()
//                        {
//                            AmountInG = 5,
//                            Sort = CoffeSorts.Robusta
//                        })
//                        .Validate(e => e.Temerature > 90)
//                    .ToBeverage();