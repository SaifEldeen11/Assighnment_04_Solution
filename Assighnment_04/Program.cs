namespace Assighnment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.WriteLine("enter a number ");
            int num = int.Parse(Console.ReadLine());
            if(num%3==0 && num%4==0)
            {
                Console.WriteLine("yes");
            }
            else
            {

                Console.WriteLine("no");
            }
            #endregion
        }
    }
}
