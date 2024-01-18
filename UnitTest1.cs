namespace SampleAssignments
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void syncTest()
        {

        }
    }

      

        class Program
        {
            static async Task Main()
            {
                Console.WriteLine("I'm in a restaurant. Let's order some food!");

                // Ordering food asynchronously
                await OrderFood();

                Console.WriteLine("The waiter brought the food. Let's eat!");
            }

            static async Task OrderFood()
            {
                Console.WriteLine("Waiter, I'd like a pizza, please.");

                // Simulate cooking asynchronously
                await CookFood();

                Console.WriteLine("The pizza is ready!");
            }

            static async Task CookFood()
            {
                Console.WriteLine("The chef is preparing the pizza...");

                // Simulate cooking time (asynchronously)
                await Task.Delay(3000); // Represents 3 seconds of cooking time
            }
        }

    }
