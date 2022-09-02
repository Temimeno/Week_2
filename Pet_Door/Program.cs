using System;

public class Program {

    public static void Main(string[] args) {
        Pet_Door door = new Pet_Door();
        door.Open();
        door.Close();
        Console.WriteLine("Door is open ? : {0}", door.isOpen());
    }
}