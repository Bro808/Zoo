using System;
using System.Xml.Linq;

public interface IAnimal
{
	public void Eat();
	public void Move();

}
public interface IPrey
{
    void RUN();
}
public interface IPredator
{
    void Hunt();
}
public abstract class Animal : IAnimal
{
	public string AName { get; set; } //animalname
	public string AType { get; set; } //predatororprey
	
	public Animal(string aname, string atype)
	{
		AName = aname;
		AType = atype;
	}
	public abstract void Move();
	public abstract void Eat();
}


public class Mammal : Animal
{
	public Mammal(string aname, string atype) : base(aname, atype) { }

    public override void Eat()
    {
        Console.WriteLine($"{AName} is feasting");
    }

    public override void Move()
    {
        Console.WriteLine($"{AName} is moving");
    }
}

public class Dog : Mammal, IPredator
{
    public Dog(string name, string atype) : base(name, atype) { }

    public override void Move()
    {
        Console.WriteLine($"{AName} has the zoomies");
    }

    public override void Eat()
    {
        Console.WriteLine($"{AName} is eating");
    }

    public void Hunt()
    {
        Console.WriteLine($"{AName} is hunting");
    }
}

public class Cat : Mammal, IPrey, IPredator
{
    public Cat(string name, string atype) : base(name, atype) { }

    public override void Eat()
    {
        Console.WriteLine($"{AName} the cat is eating.");
    }

    public override void Move()
    {
        Console.WriteLine($"{AName} the cat is sneaking around.");
    }

    public void RUN()
    {
        Console.WriteLine($"{AName} the cat is running away from danger.");
    }

    public void Hunt()
    {
        Console.WriteLine($"{AName} the cat is hunting.");
    }
}

public class Mouse : Mammal, IPrey
{
    public Mouse(string name, string atype) : base(name, atype) { }

    public override void Eat()
    {
        Console.WriteLine($"{AName} the mouse is eating.");
    }

    public override void Move()
    {
        Console.WriteLine($"{AName} the mouse is scurrying.");
    }

    public void RUN()
    {
        Console.WriteLine($"{AName} the mouse is running away from danger.");
    }
}
public class Fish : Animal
{
    public Fish(string aname, string atype) : base(aname, atype){ }
	public override void Eat()
	{
        Console.WriteLine($"{AName} is grubbin");
	}

    public override void Move()
    {
        Console.WriteLine($"{AName} is swimming");
    }
}

public class Shark : Fish, IPredator
{
    public Shark(string name, string atype) : base(name, atype) { }

    public void Hunt()
    {
        Console.WriteLine($"{AName} the shark is hunting.");
    }
}

public class Salmon : Fish, IPrey
{
    public Salmon(string name, string atype) : base(name, atype) { }

    public void RUN()
    {
        Console.WriteLine($"{AName} the salmon is swimming fast to escape.");
    }
}

public class Jellyfish : Animal
{
    public Jellyfish(string name, string atype) : base(name, atype) { }

    public override void Eat()
    {
        Console.WriteLine($"{AName} the jellyfish is eating.");
    }

    public override void Move()
    {
        Console.WriteLine($"{AName} the jellyfish is drifting.");
    }
}