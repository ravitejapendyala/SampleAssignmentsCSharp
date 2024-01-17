using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAssignments.LinQ
{
    internal class LinQConcepts
    {
        static void main(string[] args)
        {
          
        }

        [Test]
        public void DistinctTest()
        {
            var listNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 6 };
            // Identify Distinct 
            var dist = listNumbers.Distinct().ToList();
            Console.WriteLine(dist[1]);
        }
        [Test]
        public void EvenOdd()
        {
            var numList = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var even = numList.Where(x => x % 2 == 0).ToList();
            var odd = numList.Where(x => x % 2 != 0).ToList();
            even.ForEach(x => Console.WriteLine("Even are : "+x));
            odd.ForEach(x => Console.WriteLine("odd are : " + x));            
            Console.WriteLine("Even are : "+string.Join(", ", even));
            Console.WriteLine("odd are : " + string.Join(", ", odd));
            
            
            
            
        }

    }
}
