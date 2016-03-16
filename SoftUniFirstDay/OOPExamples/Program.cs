using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Dog
{
    public string Name { get; set; }
    public string Breed { get; set; }

    public Dog()
        : this(null, null)
    {
    }

    public Dog(string name, string breed)
    {
        this.Name = name;
        this.Breed = breed;
    }

    public void Bark()
    {
        bool isDog = true;
        if (this.Name == null || this.Breed == null)
        {
            isDog = false;
        }

        if (isDog)
        {
        Console.WriteLine("{0} ({1}) said: Bau wow Bau",this.Name,this.Breed);
        }
        else
        {
            Console.WriteLine("The dog is non existant");
        }
    }

}

class Program
{
    static void Main(string[] args)
    {

        Dog cezar = new Dog();
        cezar.Name = "Gosho";
        cezar.Breed = "Ulichna prevyzhodna";
        Dog cezar1 = new Dog("Sara","German Shepard");
        Dog cezar2 = new Dog();

        cezar.Bark();
        cezar1.Bark();
        cezar2.Bark();

    }
}
