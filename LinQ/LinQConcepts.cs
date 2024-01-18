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
        [Test]
        public void Sort()
        {
            var listNum = new List<int>() { 1,2,3,4,5,6,7};
            var ascOrd = listNum.OrderBy(x=>x).ToList();
            var descOrd = listNum.OrderByDescending(x=>x).ToList();
            Console.WriteLine(string.Join(" ,",ascOrd));
            Console.WriteLine(string.Join(" ,",descOrd));
            var listNum1 = new List<int>() { 1, 2, 3, 5, 4, 8, 0 };
            var ascOrd1 = listNum1.OrderBy(x => x).ToList();

        }

        [Test]
        public void FirstOrDefault()
        {
            var listNum = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var listEmp = new List<int>() { };
            var first = listNum.FirstOrDefault();
            var firstEmpty = listEmp.FirstOrDefault();
        }
        [Test]
        public void Any()
        {
            var listNum = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var listEmp = new List<int>() {3,5,7 };
            var checkEven = listNum.Any(x => x % 2 == 0);
             checkEven = listEmp.Any(x => x % 2 == 0);
        }
        [Test]
        public void All()
        {
            var listNum = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var listEmp = new List<int>() {3,5,7 };
            var checkEven = listNum.All(x => x % 2 == 0);
             checkEven = listEmp.All(x => x % 2 != 0);
        }
        [Test]
        public void SkipAndTake()
        {
            var firstList = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var secondList = new List<int>() {3,5,7 };
            var firstThree = firstList.Take(3).ToList();
            var skipThree = firstList.Skip(2).ToList();
        }
        [Test]
        public void Aggregate()
        {
            var firstList = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var sumOfAll = firstList.Aggregate((accum,num)=>accum+num);
        }
        [Test]
        public void Zip()
        {
            var firstList = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var charList = new List<char>() { 'a', 'b', 'c' };
            var result = charList.Zip(firstList, (firstList, charList) => $"{firstList}+{charList}").ToList();
           
        }



    }

    class Order
    {
        public int id { get; set; }
        public List<String> items { get; set; }

    }
}
