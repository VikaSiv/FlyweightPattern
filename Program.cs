using FlyweightPattern;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Character warrior = Character.CharacterFactory.GetCharacter("Arthur", "Warrior", "warrior.png");
        Character mage = Character.CharacterFactory.GetCharacter("Merlin", "Mage", "mage.png");
        Character anotherWarrior = Character.CharacterFactory.GetCharacter("Arthur", "Warrior", "warrior.png");

        Console.WriteLine(Object.ReferenceEquals(warrior, anotherWarrior)); 

        warrior.Level = 5;
        warrior.Experience = 200;

        Console.WriteLine($"{warrior.Name} (Level {warrior.Level}, Experience {warrior.Experience})"); 
    }
}
