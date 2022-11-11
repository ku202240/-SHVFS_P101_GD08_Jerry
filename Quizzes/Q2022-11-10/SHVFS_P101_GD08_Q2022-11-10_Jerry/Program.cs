namespace SHVFS_P101_GD08_Jerry
{
    public class Program
    {
        public static void Main()
        {
            string a, b;
            string[] names = { "Jerry", "Oli", "Navin", "People", "Shift", "Maya" ,"Tom" };
            Random rand = new Random();
            int name = rand.Next(names.Length);
            Console.WriteLine("hey,what your name?");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("ok,Let's guess the words together");
            b = Console.ReadLine();
            while   (b != names[name])
            {
                Console.WriteLine("Hee hee, let's guess the value");
                b = Console.ReadLine();
                Console.Clear();
            }
            
            //if (b == names[name])
            Console.WriteLine("You guessed it");

        }
    }
}