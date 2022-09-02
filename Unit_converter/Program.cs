using System;

public class Program {
    static void Main(string[] args) {
        Converter FeetToInches = new Converter(12);
        Converter MilesToFeet = new Converter(5280);

        Console.WriteLine("Feet to Inches: {0}", FeetToInches.convert(30));
        Console.WriteLine("Miles to Feet: {0}", MilesToFeet.convert(1));
        Console.WriteLine("Feet to Inches from Miles: {0}", FeetToInches.convert(MilesToFeet.convert(2)));
    }
}