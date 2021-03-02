using System;
using System.Collections.Generic;

public interface IBeverage{
	List<string> Ingredients { get; }
    string CupType { get; }
}

class Espresso : IBeverage
{

    public int Water { set; get; }

    public int Milk { set; get; }
    public Beans Beans = new Beans();

    public Validate val = new Validate();

    public void ToBeverage() {
        Console.WriteLine($"Lägger till {Water}ml vatten");
        Console.WriteLine($"Lägger till {Milk}ml mjölk");
        Console.WriteLine($"Lägger till {Beans.BeanAmount}st {Beans.BeanType}");
        Console.WriteLine($"Kokar kaffet i {val.Temperature} grader");
    }

    public void addWater(int amount)
    {
        Water = amount;
    }

    public void addMilk(int amount)
    {
        Milk = amount;
    }

    public void addBeans(Beans beans)
    {
        Beans.BeanAmount = beans.BeanAmount;
        Beans.BeanType = beans.BeanType;
    }

    public List<string> Ingredients => throw new System.NotImplementedException();
    public string CupType => throw new System.NotImplementedException();
}


class Latte : IBeverage
{

    public int Milk { set; get; }

    public List<string> Ingredients => throw new NotImplementedException();

    public string CupType => throw new NotImplementedException();

    public Beans Beans = new Beans();

    public Validate val = new Validate();

    public void ToBeverage()
    {
        Console.WriteLine($"Lägger till {Milk}ml mjölk");
        Console.WriteLine($"Lägger till {Beans.BeanAmount}st {Beans.BeanType}");
        Console.WriteLine($"Kokar kaffet i {val.Temperature} grader");
    }

    public void addMilk(int amount)
    {
        Milk = amount;
    }


    public void addBeans(Beans beans)
    {
        Beans.BeanAmount = beans.BeanAmount;
        Beans.BeanType = beans.BeanType;
    }
}

class Beans
{
    public int BeanAmount { set; get; }

    public string BeanType { set; get; }

}
class Validate
{
    public int Temperature { set; get; }

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