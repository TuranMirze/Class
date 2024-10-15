namespace CARSSSSSS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Hyundai", "Elantra", 15000, 2);
            car1.ShowFullInfo();
            Car car2 = new Car("MercedeS", "4goz", 23000, 3);
            car2.ShowFullInfo();
            Car car3 = new Car("Lambo", "Urus", 300, 2);
            car3.ShowFullInfo();

            MotorCycle moto1 = new MotorCycle("Yakohoma", "Harley", 6000, 2);
            moto1.ShowFullInfo();
            MotorCycle moto2 = new MotorCycle("Yakohoma", "Sparetime", 14000, 2);
            moto2.ShowFullInfo();
            MotorCycle moto3 = new MotorCycle("Yakohoma", "Geolander", 42000, 2);
            moto3.ShowFullInfo();
        }
        class Vehicle
        {
            public string Brand;
            public string Model;
            public double Mile;
            public Vehicle(string brand, string model, double mile)
            {
                if ((brand == " " || brand == "") || (model == "" || model == " "))
                {
                    Console.WriteLine("Melumatlari daxil edin");

                }
                Brand = brand;
                Model = model;
                Mile = mile;
            }
            public void ShowFullInfo()
            {
                Console.WriteLine($"Brand:{Brand},Model:{Model},Mile:{Mile}");
            }
        }

        class Car : Vehicle
        {
            public int DoorsNum;
            public Car(string brand, string model, double mile, int doorsNum) : base(brand, model, mile)
            {
                DoorsNum = doorsNum;
            }

            public void ShowFullInfo()
            {
                base.ShowFullInfo();
                Console.WriteLine($"Qapi sayi: {DoorsNum}");
            }
        }

        class MotorCycle : Vehicle
        {
            public int WheelNum;

            public MotorCycle(string brand, string model, double mile, int wheelNum) : base(brand, model, mile)
            {
                WheelNum = wheelNum;
            }

            public void ShowFullInfo()
            {
                base.ShowFullInfo();
                Console.WriteLine($"Teker sayi: {WheelNum}");
            }
        }

    }
}