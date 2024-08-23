using System.Text;

namespace Lesson3.Practical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //string number = "0123456489";
            #region Task OOP1
            /*
            Tələbə Class yaradın.
            İstifadəçidən tələbənin
            adı,soyadı,yaşı,gpa,IsExcellent daxil edib
            ekrana aydın şəkildə dataları yazdırın.
             */

            //Console.WriteLine("Tələbənin adını daxil edin");
            //string name = Console.ReadLine();

            //Console.WriteLine("Tələbənin soyadını daxil edin");
            //string surname = Console.ReadLine();

            //Console.WriteLine("Tələbənin yaşı daxil edin");
            //byte age = Convert.ToByte(Console.ReadLine());

            //Console.WriteLine("Tələbənin ortalaması daxil edin");
            //double gpa =Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Tələbənin əlaçı olub olmamasını daxil edin");
            //bool isExcellent = Convert.ToBoolean(Console.ReadLine());

            //Student student = new()
            //{
            //    Name = name,
            //    Surname = surname,
            //    Age = age,
            //    Gpa = gpa,
            //    IsExcellent = isExcellent
            //};

            //Console.WriteLine($"Tələbənin adı: {student.Name}");
            //Console.WriteLine($"Tələbənin soyadı: {student.Surname}");
            //Console.WriteLine($"Tələbənin yaşı: {student.Age}");
            //Console.WriteLine($"Tələbənin ortalama: {student.Gpa}");
            //if (student.IsExcellent)
            //{
            //    Console.WriteLine($"Tələbənin əlaçılığı: Əlaçıdır");
            //}
            //else
            //{
            //    Console.WriteLine($"Tələbənin əlaçılığı:Əlaçı deyil");
            //}

            #endregion

            #region Task2
            string text = "Codinarium";

            string reversedText = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedText += text[i];
            }
            Console.WriteLine(reversedText);

            #endregion


        }
    }
    //public class Student
    //{
    //    public string Name { get; set; }
    //    public string Surname { get; set; }
    //    public byte Age { get; set; }
    //    public double Gpa { get; set; }
    //    public bool IsExcellent { get; set; }
    //}
}
