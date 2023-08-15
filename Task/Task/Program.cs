namespace Task
{
    internal class Program
    {
        public class MathHelper
        {
            public int PrintValue(int a, int b)
            {
                return a + b;
            }
            public int PrintValue(bool a)
            {
                if (a == true) {return 1;} 
                else { return 0;}
            }
            public void PrintValue(string a,string b)
            {
                Console.WriteLine(a + b);
            }
            public int PrintValue(int a,int b,int c)
            {
                return a * b * c;
            }
        }
        static void Main(string[] args)
        {
            var test1 = new MathHelper();
            Console.WriteLine(test1.PrintValue(1, 2));
            Console.WriteLine(test1.PrintValue(true));
            test1.PrintValue("Murad "," Mammedzade");
            Console.WriteLine(test1.PrintValue(1, 2, 3));
        }
    }
}