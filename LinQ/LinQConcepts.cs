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

    }
}
