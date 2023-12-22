Dog volf = new Dog("Гав", "sas", "dnim");
volf.makeNoise();
Cat dogi = new Cat("Мяу", "korm", "home");
dogi.eat();
Horse sabina = new Horse("Ааа", "seno", "zagon");
sabina.sleep();
class Animal
{
    public string food;
    public string location;
    public Animal(string food, string location)
    {
        this.food = food;
        this.location = location;
    }
    public virtual void makeNoise()
    {
        Console.WriteLine($"Животное шумит");
    }
    public virtual void eat()
    {
        Console.WriteLine($"Животное ест");
    }
    public virtual void sleep()
    {
        Console.WriteLine($"Животное спит");
    }
}
class Dog : Animal
{
    public string name;
    public Dog(string name, string food, string location) : base(food, location)
    {
        this.name = name;
    }
    public override void makeNoise()
    {
        Console.WriteLine($"{this.name} издает звук {this.makeNoise}");
    }
}

class Cat : Animal
{
    public string name;
    public Cat(string name, string food, string location) :
    base(food, location)
    {
        this.name = name;
    }
    public override void eat()
    {
        Console.WriteLine($"{this.name} ест");
    }
}
class Horse : Animal
{
    public string name;
    public Horse(string name, string food, string location) :
    base(food, location)
    {
        this.name = name;
    }
    public override void sleep()
    {
        Console.WriteLine($"{name} спит");
    }
}
