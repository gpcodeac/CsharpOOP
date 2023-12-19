using Lecture203.Class_collection;

namespace Lecture203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo ch;
            while (true)
            {
                TaskOrchestrator();

                Console.Write("Press the Escape (Esc) key to quit\n\n\n");
                ch = Console.ReadKey();
                if (ch.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }

        static void TaskOrchestrator()
        {
            Console.WriteLine("Choose the task number:");
            string taskNr = Console.ReadLine();
            switch (taskNr)
            {
                case "1.1":
                    Task1p1();
                    break;
                case "1.2":
                    Task1p2();
                    break;
                case "2.1":
                    Task2p1();
                    break;
                case "2.2":
                    Task2p2();
                    break;

                case "3.1":
                    Task3p1();
                    break;
                case "3.2":
                    Task3p2();
                    break;
                case "3.3":
                    Task3p3();
                    break;
                case "4.1":
                    Task4p1();
                    break;
                case "4.2":
                    Task4p2();
                    break;


                //case "000":
                //    Test0();
                //    break;
                default:
                    Console.WriteLine("No such task number.");
                    break;
            }
        }

        static void Task1p1()
        {
            Car car1 = new Car();
            car1.Speed = 60;
            Car car2 = new Car(1380, 192, 450.33, 19, 65);
            Console.WriteLine("Car1 speed: " + car1.Speed);
            Console.WriteLine("Car2 speed: " + car2.Speed);

            Bike bike1 = new Bike();
            bike1.Speed = 20;
            Bike bike2 = new Bike(2, 0, 0.1, 25);
            Console.WriteLine("Bike1 speed: " + bike1.Speed);
            Console.WriteLine("Bike2 speed: " + bike2.Speed);
        }
        static void Task1p2()
        {
            Employee employee1 = new Employee("John", "Smith", 1000);
            Employee employee2 = new Employee("Jane", "Doe", 2000);
            Employee employee3 = new Employee("Jim", "Jeffries", 3000);
            Employee employee4 = new Employee("Jack", "Black", 4000);
            Employee employee5 = new Employee("Jill", "Valentine", 4444);
            Manager manager1 = new Manager("Alice", "InChains", 5000, 500);
            Manager manager2 = new Manager("Bob", "Dylan", 5000, 200);
            manager1.AddEmployee(employee1);
            manager1.AddEmployee(employee2);
            manager2.AddEmployee(employee3);
            manager2.AddEmployee(employee4);
            manager2.AddEmployee(employee5);
            Console.WriteLine(manager1.EmployeeData());
            Console.WriteLine(manager2.EmployeeData());

            
            Programmer programmer1 = new Programmer("Jane", "Doe", 2000, "Javascript");
            manager1.AddProgrammer(programmer1);
            Programmer programmer2 = new Programmer("Jill", "Valentine", 4444, "C#");
            manager2.AddProgrammer(programmer2);
            manager1.PrintProgrammers();
            manager2.PrintProgrammers();
        }
       
        static void Task2p1()
        {
            Food sausage = new Food("Sausage", 2.99, 1, new System.DateTime(2023, 12, 31));
            Food milk = new Food("Milk", 1.99, 1, new System.DateTime(2023, 12, 23));
            Food bread = new Food("Bread", 1.99, 1, new System.DateTime(2023, 12, 25));
            Food cheese = new Food("Cheese", 3.99, 1, new System.DateTime(2023, 11, 02));

            Console.WriteLine($"{sausage.Name} expires {sausage.ExpirationDate}");
            Console.WriteLine($"{milk.Name} expires {milk.ExpirationDate}");
            Console.WriteLine($"{bread.Name} expires {bread.ExpirationDate}");
            Console.WriteLine($"{cheese.Name} expires {cheese.ExpirationDate}");

            Electronics tv = new Electronics("LG HDTV", 999.99, 1, "2 years");
            Electronics phone = new Electronics("Nokia", 699.99, 1, "1 year");
            Electronics laptop = new Electronics("MacBook Air", 1299.99, 1, "2 years");
            Electronics tablet = new Electronics("iPad", 499.99, 1, "1 year");

            Console.WriteLine($"{tv.Name} warranty is {tv.Warranty}");
            Console.WriteLine($"{phone.Name} warranty is {phone.Warranty}");
            Console.WriteLine($"{laptop.Name} warranty is {laptop.Warranty}");
            Console.WriteLine($"{tablet.Name} warranty is {tablet.Warranty}");
        }
        static void Task2p2()
        {
            Customer customer1 = new Customer("German", "Paskovskij", "123456789", false);
            Customer customer2 = new Customer("Jane", "Doe", "987654321", true);
            
            FleetUnit fleetUnit1 = new FleetUnit("Golf", "VW777788899996", 5, 57986);
            FleetUnit fleetUnit2 = new FleetUnit("Tesla", "VIN 1231 4458 8978", 5, 12354);
            FleetUnit fleetUnit3 = new FleetUnit("Yaris", "JP6545424632154652", 2, 8503);
            fleetUnit1.Reserve();
            fleetUnit3.Reserve();

            customer1.ReserveFleetUnit(fleetUnit1); // should fail as fleetUnit1 is already reserved
            Reservation? myRes = customer1.ReserveFleetUnit(fleetUnit2); // should reserve fleetUnit2
            Console.WriteLine();
            customer2.ReserveFleetUnit(fleetUnit2); // should fail as fleetUnit2 is already reserved
            Console.WriteLine();
            fleetUnit2.Odometer += 46; // simulate driving
            customer1.EndReservation(myRes); // ending reservation
            Console.WriteLine();
            customer1.PaymentHistory[0].PrintPayment(); // should print out the payment details for 46 km trip
            Console.WriteLine();
            customer1.ReservationHistory[0].PrintReservation(); // should print out the reservation details for 46 km trip
            Console.WriteLine();
            customer1.SettlePayment(6);
            customer1.PaymentHistory[0].PrintPayment(); // to show that partial payment was applied
            Console.WriteLine();
            customer1.SettlePayment(7.5);
            customer1.PaymentHistory[0].PrintPayment(); // to show that full payment was applied

        }
        
        static void Task3p1()
        {

        }
        static void Task3p2()
        {

        }
        static void Task3p3()
        {

        }
        static void Task4p1()
        {

        }
        static void Task4p2()
        {

        }



    }
}