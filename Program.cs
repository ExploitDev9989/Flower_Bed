namespace Flower_Bed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] flowers = { 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0 };
            Console.WriteLine("Your flowerbed : " + string.Join(",", flowers));
            
            Console.WriteLine("How many flowers would you like to plant?");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < flowers.Length; i++)
                

            {
                
                bool leftEmpty = (i == 0) || (flowers[i - 1] == 0);
                bool rightEmpty = (i == flowers.Length - 1) || (flowers[i + 1] == 0);


                if (flowers[i] == 0)
                    if (leftEmpty && rightEmpty)
                    {
                        flowers[i] = 1;
                        n--;
                    }
                
    
            }
            if (n <= 0)
            {
                Console.WriteLine("Your flowerbed updated : " + string.Join(",", flowers));
                Console.WriteLine("all plants planted");
            }
            else
            {
                
                Console.WriteLine("Unable to plant all plants");
            }
                


        }
    }
}
