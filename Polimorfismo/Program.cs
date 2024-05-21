//Sebastian Borja 
using System;

class Animal  // Clase base (padre) 
{
    public virtual void animalSound()  // Método virtual para ser sobrescrito
    {
        Console.WriteLine("El animal hace un sonido");
    }
}

class Gato : Animal  // Clase derivada (hijo) 
{
    public override void animalSound()  // Sobrescribe el método animalSound
    {
        Console.WriteLine("El gato dice: ¡miau!");
    }
}

class Caballo : Animal  // Clase derivada (hijo) 
{
    public override void animalSound()  // Sobrescribe el método animalSound
    {
        Console.WriteLine("El caballo dice: ¡relincho!");
    }
}

class Perro : Animal  // Clase derivada (hijo) 
{
    public override void animalSound()  // Sobrescribe el método animalSound
    {
        Console.WriteLine("El perro dice: ¡guau!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal miAnimal = new Animal();  // Crea un objeto Animal
        Animal miGato = new Gato();  // Crea un objeto Gato
        Animal miCaballo = new Caballo();  // Crea un objeto Caballo
        Animal miPerro = new Perro();  // Crea un objeto Perro

        miAnimal.animalSound();
        miGato.animalSound();
        miCaballo.animalSound();
        miPerro.animalSound();
    }
}
