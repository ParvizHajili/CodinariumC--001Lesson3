using System.Text;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string text = "Azərbaycan";
            int count = 0;
            foreach (var item in text.ToLower())
            {
                if(item == 'a')
                {
                    count++;
                }
            }

            Console.WriteLine($"{text} sözündə {count} dənə.a hərfi mövcuddur");
        }
    }
}
