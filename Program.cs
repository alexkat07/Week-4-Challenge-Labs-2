using System.Numerics;

namespace Challenge_Labs_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 25, 12, 43 };

            var occurrenceDict = new Dictionary<int, int>();

            for (int i = 0; i < myArray.Length; i++) 
            {
                if (occurrenceDict.ContainsKey(myArray[i])) 
                {
                    occurrenceDict[myArray[i]]+=1;
                }
                else 
                {
                    occurrenceDict.Add(myArray[i], 1);
                }
                

            }
            foreach (var item in occurrenceDict) 
            {
                Console.WriteLine($"{item.Key} occurs {item.Value} times");
            }


        }
    }
}
