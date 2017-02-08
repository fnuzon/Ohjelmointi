using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeBoatApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, inpuT, year, seatcount, index;
            string name, model, color, gear, boattype, inpt, gearwheels;
            bool Gearwheels;

            List<Vehicle> vehicles = new List<Vehicle>();
            List<Boat> boats = new List<Boat>();
            List<Bike> bikes = new List<Bike>();
            do
            {
                Console.WriteLine("1. Add new vehicle:");
                Console.WriteLine("2. Change data:");
                Console.WriteLine("3. Print data:");
                Console.WriteLine("0. To end the application:");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("1. To add new vehicle:");
                    Console.WriteLine("2. To add new bike:");
                    Console.WriteLine("3. To add new boat:");
                    inpuT = int.Parse(Console.ReadLine());
                    if (inpuT == 1)
                    {
                        Console.WriteLine("Give a name for the vehicle");
                        name = Console.ReadLine();
                        Console.WriteLine("Give a model");
                        model = Console.ReadLine();
                        Console.WriteLine("Give give a model year");
                        year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Give give a color");
                        color = Console.ReadLine();
                        vehicles.Add(new Vehicle(name, model, year, color));
                        Console.WriteLine("Added!");
                    }
                    if (inpuT == 2)
                    {
                        Console.WriteLine("Give a name for the bike");
                        name = Console.ReadLine();
                        Console.WriteLine("Give a model");
                        model = Console.ReadLine();
                        Console.WriteLine("Give give a model year");
                        year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Give give a color");
                        color = Console.ReadLine();
                        Console.WriteLine("Does bike have gearwheel? yes or no");
                        gearwheels = Console.ReadLine();
                        if (gearwheels == "yes")
                        {
                            Gearwheels = true;
                        }
                        else
                        {
                            Gearwheels = false;
                        }
                        Console.WriteLine("Give Gear name");
                        gear = Console.ReadLine();
                        bikes.Add(new Bike(name, model, year, color, Gearwheels, gear));
                        Console.WriteLine("Added!");
                    }
                    if (inpuT == 3)
                    {
                        Console.WriteLine("Give a name for the boat");
                        name = Console.ReadLine();
                        Console.WriteLine("Give a model");
                        model = Console.ReadLine();
                        Console.WriteLine("Give give a model year");
                        year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Give give a color");
                        color = Console.ReadLine();
                        Console.WriteLine("Give a seatcount");
                        seatcount = int.Parse(Console.ReadLine());
                        Console.WriteLine("Give a boattype");
                        boattype = Console.ReadLine();
                        boats.Add(new Boat(name, model, year, color, seatcount, boattype));
                    }
                }

                if (input == 2)
                {
                    Console.WriteLine("1. To change bike data");
                    Console.WriteLine("2. To change boat data");
                    inpuT = int.Parse(Console.ReadLine());
                    if (inpuT == 1)
                    {
                        foreach (Bike bike in bikes)
                        {
                            Console.WriteLine("Name: " + bike.name + ", Model: " + bike.model + ", ModelYear: " + bike.year + ", Color: " + bike.color + ", GearWheels: " + bike.gearwheels + ", Gear Name: " + bike.gear);
                        }
                        Console.WriteLine("What to change(name, model, year, color, gearwheels, gearname)");
                        inpt = Console.ReadLine();
                        if (inpt == "name")
                        {
                            Console.WriteLine("Give index number of bike example.. 0,1,2,3...");
                            index = int.Parse(Console.ReadLine());
                            Console.WriteLine("Give a new name");
                            name = Console.ReadLine();
                            bikes[index].name = name;
                            Console.WriteLine("Changed!");
                        }
                        if (inpt == "model")
                        {
                            Console.WriteLine("Give index number of bike example.. 0,1,2,3...");
                            index = int.Parse(Console.ReadLine());
                            Console.WriteLine("Give a new model");
                            model = Console.ReadLine();
                            bikes[index].model = model;
                            Console.WriteLine("Changed!");
                        }
                        if (inpt == "year")
                        {
                            Console.WriteLine("Give index number of bike example.. 0,1,2,3...");
                            index = int.Parse(Console.ReadLine());
                            Console.WriteLine("Give a new year");
                            year = int.Parse(Console.ReadLine());
                            bikes[index].year = year;
                            Console.WriteLine("Changed!");
                        }
                        if (inpt == "color")
                        {
                            Console.WriteLine("Give index number of bike example.. 0,1,2,3...");
                            index = int.Parse(Console.ReadLine());
                            Console.WriteLine("Give a new color");
                            color = Console.ReadLine();
                            bikes[index].color = color;
                            Console.WriteLine("Changed!");
                        }
                        if (inpt == "gearwheels")
                        {
                            Console.WriteLine("Give index number of bike example.. 0,1,2,3...");
                            index = int.Parse(Console.ReadLine());
                            Console.WriteLine("Give a new gearwheels(yes or no)");
                            gearwheels = Console.ReadLine();
                            if (gearwheels == "yes")
                            {
                                Gearwheels = true;
                            }
                            else
                            {
                                Gearwheels = false;
                            }
                            bikes[index].gearwheels = Gearwheels;
                            Console.WriteLine("Changed!");
                        }
                        if (inpt == "gearname")
                        {
                            Console.WriteLine("Give index number of bike example.. 0,1,2,3...");
                            index = int.Parse(Console.ReadLine());
                            Console.WriteLine("Give a new gearname");
                            gear = Console.ReadLine();
                            bikes[index].gear = gear;
                            Console.WriteLine("Changed!");
                        }
                    }
                    if (inpuT == 2)
                    {
                        foreach (Boat boat in boats)
                        {
                            Console.WriteLine("Name: " + boat.name + ", Model: " + boat.model + ", ModelYear: " + boat.year + ", Color: " + boat.color + ", SeatCount: " + boat.seatcount + ", BoatType: " + boat.boatType);
                        }
                        Console.WriteLine("What to change(name, model, year, color, seatcount, boattype)");
                        inpt = Console.ReadLine();
                        if (inpt == "name")
                        {
                            Console.WriteLine("Give index number of boat example.. 0,1,2,3...");
                            index = int.Parse(Console.ReadLine());
                            Console.WriteLine("Give a new name");
                            name = Console.ReadLine();
                            boats[index].name = name;
                            Console.WriteLine("Changed!");
                        }
                        if (inpt == "model")
                        {
                            Console.WriteLine("Give index number of boat example.. 0,1,2,3...");
                            index = int.Parse(Console.ReadLine());
                            Console.WriteLine("Give a new model");
                            model = Console.ReadLine();
                            boats[index].model = model;
                            Console.WriteLine("Changed!");
                        }
                        if (inpt == "year")
                        {
                            Console.WriteLine("Give index number of boat example.. 0,1,2,3...");
                            index = int.Parse(Console.ReadLine());
                            Console.WriteLine("Give a new year");
                            year = int.Parse(Console.ReadLine());
                            boats[index].year = year;
                            Console.WriteLine("Changed!");
                        }
                        if (inpt == "color")
                        {
                            Console.WriteLine("Give index number of boat example.. 0,1,2,3...");
                            index = int.Parse(Console.ReadLine());
                            Console.WriteLine("Give a new color");
                            color = Console.ReadLine();
                            boats[index].color = color;
                            Console.WriteLine("Changed!");
                        }
                        if (inpt == "seatcount")
                        {
                            Console.WriteLine("Give index number of boat example.. 0,1,2,3...");
                            index = int.Parse(Console.ReadLine());
                            Console.WriteLine("Give a new year");
                            seatcount = int.Parse(Console.ReadLine());
                            boats[index].seatcount = seatcount;
                            Console.WriteLine("Changed!");
                        }
                        if (inpt == "boattype")
                        {
                            Console.WriteLine("Give index number of boat example.. 0,1,2,3...");
                            index = int.Parse(Console.ReadLine());
                            Console.WriteLine("Give a new color");
                            boattype = Console.ReadLine();
                            boats[index].boatType = boattype;
                            Console.WriteLine("Changed!");
                        }
                    }
                    
                }
             if (input == 3)
             {
                    Console.WriteLine("1. Print vehicles");
                    Console.WriteLine("2. Print bikes");
                    Console.WriteLine("3. Print boats");
                    Console.WriteLine("4. Print all");
                    inpuT = int.Parse(Console.ReadLine());
                    if (inpuT == 1)
                    {
                        Console.WriteLine("Vehicles:");
                        foreach (Vehicle vehicle in vehicles)
                        {
                            Console.WriteLine("Name: " + vehicle.name + ", Model: " + vehicle.model + ", ModelYear: " + vehicle.year + ", Color: " + vehicle.color );
                        }
                    }
                    if (inpuT == 2)
                    {
                        Console.WriteLine("Bikes:");
                        foreach (Bike bike in bikes)
                        {
                            Console.WriteLine("Name: " + bike.name + ", Model: " + bike.model + ", ModelYear: " + bike.year + ", Color: " + bike.color + ", GearWheels: " + bike.gearwheels + ", Gear Name: " + bike.gear);
                        }
                    }
                    if (inpuT == 3)
                    {
                        Console.WriteLine("Boats:");
                        foreach (Boat boat in boats)
                        {
                            Console.WriteLine("Name: " + boat.name + ", Model: " + boat.model + ", ModelYear: " + boat.year + ", Color: " + boat.color + ", SeatCount: " + boat.seatcount + ", BoatType: " + boat.boatType);
                        }
                    }
                    if (inpuT == 4)
                    {
                        Console.WriteLine("Vehicles:");
                        foreach (Vehicle vehicle in vehicles)
                        {
                            Console.WriteLine("Name: " + vehicle.name + ", Model: " + vehicle.model + ", ModelYear: " + vehicle.year + ", Color: " + vehicle.color);
                        }
                        Console.WriteLine("Bikes:");
                        foreach (Bike bike in bikes)
                        {
                            Console.WriteLine("Name: " + bike.name + ", Model: " + bike.model + ", ModelYear: " + bike.year + ", Color: " + bike.color + ", GearWheels: " + bike.gearwheels + ", Gear Name: " + bike.gear);
                        }
                        Console.WriteLine("Boats:");
                        foreach (Boat boat in boats)
                        {
                            Console.WriteLine("Name: " + boat.name + ", Model: " + boat.model + ", ModelYear: " + boat.year + ", Color: " + boat.color + ", SeatCount: " + boat.seatcount + ", BoatType: " + boat.boatType);
                        }
                    }
                }  
              
            }
            while (input != 0) ;
        }
    }
}
