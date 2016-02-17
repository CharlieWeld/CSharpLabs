using System;

namespace Ships
{
    namespace ShipYard
    {
        public class Ferry
        {
            private string regNumber;
            private int noPassengers;
            private int noAdultPassengers;
            private int noCars;
            private int totalPassengers;
            private int totalSinglePassengers;
            private double charge;
            private double totalCharge;

            // default constructor
            public Ferry()
            {
                totalPassengers = 0;
                totalSinglePassengers = 0;
                totalCharge = 0;
            }

            // determine the number of passengers in the car
            // determine if the passengers are 
            public void getAdultPassengers()
            {
                string adult;
                // reset charge to zero for each car
                noCars++; // increment the number of cars
                this.noAdultPassengers = 0;

                // update the number of single passenger vehicles
                if (noPassengers == 1)
                {
                    this.totalSinglePassengers++;
                }

                // find passengers over 18
                for (int i = 0; i < noPassengers; i++)
                {
                    Console.Write("Is passenger " + (i + 1) + " over 18 (yes/no): ");
                    adult = Console.ReadLine();

                    // count the number of passengers over 18
                    if (adult == "yes")
                    {
                        this.noAdultPassengers++;
                    }
                }
            }
            public void calcCharge()
            {
                this.charge = 0;  // reset charge for each car
                this.charge += 100;
                this.charge += this.noAdultPassengers * 20;
                charge += (noPassengers - noAdultPassengers) * 10;

                // increase the total charge for the day
                totalCharge += charge;
            }
            public void setRegistration(string regNum)
            {
                this.regNumber = regNum;
            }
            public double getCharge()
            {
                return this.charge;
            }

            public string getRegNumber()
            {
                return this.regNumber;
            }

            public int getTotalPassengers()
            {
                return this.totalPassengers;
            }

            public int getTotalCars()
            {
                return this.noCars;
            }

            public double getTotalCharge()
            {
                return this.totalCharge;
            }

            public int getSinglePassengers()
            {
                return this.totalSinglePassengers;
            }

            public void setNoPassengers(int noPassengers)
            {
                this.noPassengers = noPassengers;
                totalPassengers += this.noPassengers;
            }
        }
    }
}