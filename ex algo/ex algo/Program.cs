using System;

namespace ex_algo
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            string category = "";
            Console.WriteLine("Quel est ton age?");
            age = Convert.ToInt32(Console.ReadLine());

            calculerCategory(age, out category);

            Console.WriteLine(category);
        }
        static void calculerCategory(int age, out string category) {
            if (age < 5 || age > 14)    {
                category = "age trop grand ou trop petit.";
            }else if (age < 8) {
                category = "poussin";
            }else if (age < 10) {
                category = "pupille";
            }else if (age < 12) {
                category = "minime";
            }else  {
                category = "cadet";
            }
        }
    }
}
