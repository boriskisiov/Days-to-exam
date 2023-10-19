namespace Days_to_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            for(int i = days; i >= 1; i -= 1)
            {
                Console.WriteLine($"{i} days before exam", i);
            }
            Console.WriteLine("The exam has come");
        } 
    }
}