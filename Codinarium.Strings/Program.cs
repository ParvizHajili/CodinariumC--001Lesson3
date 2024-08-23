using System.Text;

namespace Codinarium.Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region Nezeri
            ///var student = Db.Students.GetStudent();
            //if(student == null)
            //{
            //  CW("Student is null");
            //}
            //string text = "Codinarium";

            //string nullValue = null;//default
            //string emptyValue = ".";

            //null check
            //defensive coding
            //var firstValue = text[0];
            //Console.WriteLine(firstValue);

            //foreach (var item in text)
            //{
            //    Console.WriteLine(item);
            //}
            //StringBuilder sb = new StringBuilder();

            //sb.Append("Parviz");
            //sb.Append("Hajili");
            //string name = "Parviz ";
            //string surName = "Hajili ";
            //int age = 55;

            //string fullName = name + surName;

            //Console.WriteLine(fullName);

            //var about = string.Format("Adınız {0},Soyadınız {1},Yaşınız {2}", name, surName, age);


            //string about = $"Ad: {name},Soyad:{surName},Yaş:{age}";

            //var about =string.Concat(name, surName, age);
            //Console.WriteLine(about);

            //var text = @"Select * from Students
            //    where age> 20";

            //Console.WriteLine(text);

            //string name = "CodinaRium";
            //string text = "Salam";

            //var name1 = name.Substring(4);
            //var name1 = name.Remove(3);

            //var name1 = name.Trim();
            //var name1 = name.TrimEnd();
            //var name1 = name.TrimStart();
            //var name1 = name.ToLower();
            //var name1 = name.ToUpper();
            //var name1 = name.Reverse();
            //var name1 = name.IndexOf('a');
            //var name1 = name.LastIndexOf('a');

            //string text = "Mən C# öyrənirəm.Və artıq fundamentalı#bitirirəm";

            //var splitText = text.Split('.',' ','#');

            ////string a = splitText[2];

            //foreach (var split in splitText)
            //{
            //    Console.WriteLine(split);
            //}

            //Console.Write(text);

            //string text = "Hello";

            //var value =text.Contains('p');

            //Console.WriteLine(value);

            //{
            //    int hello = 5;
            //    {
            //        hello = 1;
            //        int b = 10;
            //    }

            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.WriteLine("Hello");
            //    }
            //}

            //int a = 3;
            //bool value = false;
            //if (a == 1)
            //{
            //    if(value)
            //    Console.WriteLine("Yanvar");

            //}
            //else if (a == 2)
            //{
            //    Console.WriteLine("Fevral");
            //}
            //else if(a == 3)
            //{
            //    Console.WriteLine("Mart")
            //}

            #endregion

            #region Task1
            /*
             Istifadeci daxil etdiyi ededi yoxlayan proqram
            hem 30-a hem 18e hem de 7ye bolunurse.Eded 30,18,7-ye bolunur
            hem 30a hem 18e bolunurse. Eded 30,18-e bolunur.lakin 7ye bolunmur.
            yalnizca 7-ye bolunurse. eded 7ye bolunur.
             */
            #endregion

            #region Task2
            // Mən info@codinairum.edu.az mail adresindən mail aldım.
            //Bu cumlədə olan mail adresini 
            //ayrıca ekrana yazdırmaq

            #endregion

        }
    }
}
