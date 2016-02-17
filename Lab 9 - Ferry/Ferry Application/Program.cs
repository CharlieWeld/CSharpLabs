using System;
using Ships.ShipYard;

class Program
{
    static void Main(string [] args)
    {
        Ferry ferry = new Ferry();
        bool carsLeft;  // this flag controls the while loop 
        string decision;  // used to test whether there are more cars to board the ferry

        Console.WriteLine("Welcome to Dublin / Hollyhead Ferry\n");

        // do while loop ensures a least one car per day will be boarded
        // 
        do
        {
            // get the registration of the car
            Console.Write("Enter the car registration: ");
            ferry.setRegistration(Console.ReadLine());

            // get the number of people in the car
            Console.Write("How many people are in the car " + ferry.getRegNumber() + ": ");
            ferry.setNoPassengers(int.Parse(Console.ReadLine()));
            ferry.getAdultPassengers();

            // calculate the charge of boarding the ferry
            ferry.calcCharge();
            Console.WriteLine("The Charge for " + ferry.getRegNumber() + " is \u00A3" + ferry.getCharge());

            // ask user if there are more cars to board the ferry
            Console.Write("\nAre there any more cars waiting to board (yes/no)? ");
            decision = Console.ReadLine();
            if (decision == "yes")
            {
                carsLeft = true;
            }
            else
            {
                carsLeft = false;
            }
            Console.WriteLine();
        }
        while (carsLeft);

        // display the stats for the day
        Console.WriteLine("The total number of passengers today were " + ferry.getTotalPassengers());
        Console.WriteLine("The total number of cars today were " + ferry.getTotalCars());
        Console.WriteLine("The total charges for the day were " + ferry.getTotalCharge());
        Console.WriteLine("The number of cars with one passenger were " + ferry.getSinglePassengers());
        Console.Write("Press Any Key to continue . . . . .");
        string tmp = Console.ReadLine();
    }
}