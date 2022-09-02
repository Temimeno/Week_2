class Program {
    static void Main(string[] args) {
        Car myCar = new Car();
        myCar.brand = "Toyota";
        myCar.model = "Altis";
        myCar.numberOfDoors = 4;
        myCar.numberOfWheels = 4;

        Car myCar2 = new Car();
        myCar2.brand = "Honda";
        myCar2.model = "Civic";
        myCar2.numberOfDoors = 8;
        myCar2.numberOfWheels = 2;

        PrintCarInformation(myCar);
        PrintCarInformation(myCar2);
    }

    static void PrintCarInformation(Car car) {
        Console.WriteLine("****************************");
        Console.WriteLine("Brand {0}", car.brand);
        Console.WriteLine("Model {0}", car.model);
        Console.WriteLine("Number of Door: {0}", car.numberOfDoors);
        Console.WriteLine("Number of Wheels: {0}", car.numberOfWheels);
        Console.WriteLine(car.MoveForward());
        Console.WriteLine(car.MoveBackward());
        Console.WriteLine(car.Stop());
        Console.WriteLine(car.Turn());
        Console.WriteLine("****************************");
    }
}