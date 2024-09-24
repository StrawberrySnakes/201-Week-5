namespace week5Demo1
{
    internal class Program
    {

        public static string printStuff(int num, string name)
        {
            string numString = num.ToString();
            return name + numString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int myFavoriteNum = 3;
            int bestNumber = 7;
            int sum;

            bool thisIsTrue = false;
            string myName = "dessa";
            float myFloat = (float)4.7;

            

            string numberString = bestNumber.ToString();


            sum = bestNumber + myFavoriteNum;

            Console.WriteLine(sum + " "+printStuff(5, "Kate")+ " "+myFloat);

            

        }
     }
}

