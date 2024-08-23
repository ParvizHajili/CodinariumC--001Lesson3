using CarProject.Concrete;
using CarProject.Models;

namespace CarProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new();

           
            while (true)
            {
                Console.WriteLine("Enter a number");
                Console.WriteLine("1-Add Car");
                Console.WriteLine("2-Show Cars");
                Console.WriteLine("3-Show 5 cars");
                Console.WriteLine("4-Finish Program");

                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter code");
                            int code = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Model");
                            string model = Console.ReadLine();
                            Console.WriteLine("Enter Marka");
                            string marka = Console.ReadLine();
                            Console.WriteLine("Enter Color");
                            string color = Console.ReadLine();

                            Car car = new()
                            {
                                Code = code,
                                Model = model,
                                Marka = marka,
                                Color = color
                            };

                            carManager.Add(car);
                            Console.WriteLine("Car succesfully added");
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            var data = carManager.GetAll();

                            foreach (var item in data)
                            {
                                Console.WriteLine($"{item.Code}  {item.Marka}  {item.Model} {item.Color}");
                            }
                            break;
                        }
                    case 4:
                        {
                            return;
                        }
                }
            }
        }
    }
}
/*
 
  public int Code { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }
        public string Color { get; set; }
 */
