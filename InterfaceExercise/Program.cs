using Microsoft.VisualBasic;
using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            // - Create 2 Interfaces called IVehicle & ICompany

            // - Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* -  Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /* - Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /* - Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * - Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            // - Now, create objects of your 3 classes and give their members values;
            // - Creatively display and organize their values

            Car myFirst = new Car { Year = "1998", Make = "Honda", Model = "Civic", HasTrunk = true, HasSunRoof = true, Logo = "H", NumberOfWheels = 4, TagLine = "The power of dreams"};
            SUV mySUV = new SUV { Year = "2020", Make = "Toyota", Model = "Highlander", HasFourWheelDrive = true, HasThirdRow = true, Logo = "T", TagLine = "Let's go places", NumberOfWheels = 4};
            Truck myTruck = new Truck { Year = "2015", Make = "Chevy", Model = "Silverado", HasBedCover = true, CrewCab = true, Logo = "Cross", NumberOfWheels = 4, TagLine = "Find new roads" };

            Console.WriteLine($"Year: {myFirst.Year} Make: {myFirst.Make} Model: {myFirst.Model} Has Trunk: {myFirst.HasTrunk} Has Sunroof: {myFirst.HasSunRoof} Number of Wheels: {myFirst.NumberOfWheels} {myFirst.Make} Logo: {myFirst.Logo} {myFirst.Make} Tagline: {myFirst.TagLine}");
            Console.WriteLine($"Year: {mySUV.Year} Make: {mySUV.Make} Model: {mySUV.Model} Has Four Wheel Drive: {mySUV.HasFourWheelDrive} Has Third Row: {mySUV.HasThirdRow} Number of Wheels: {mySUV.NumberOfWheels} {mySUV.Make} Logo: {mySUV.Logo} {mySUV.Make} Tagline: {mySUV.TagLine}");
            Console.WriteLine($"Year: {myTruck.Year} Make: {myTruck.Make} Model: {myTruck.Model} Has Bed Cover: {myTruck.HasBedCover} Crew Cab: {myTruck.CrewCab} Number of Wheels: {myTruck.NumberOfWheels} {myTruck.Make} Logo: {myTruck.Logo} {myTruck.Make} Tagline: {myTruck.TagLine}");

        }
    }
}
