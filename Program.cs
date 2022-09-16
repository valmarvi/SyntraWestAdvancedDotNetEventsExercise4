using System;

namespace SyntraWestAdvancedDotNetEventsExercise4
{

    class Program
    {
        static void Main(string[] args)
        {
            var bucket = new Bucket(100);

            bucket.AlmostFull += Bucket_AlmostFull;
            bucket.Full += Bucket_Full;

            bucket.Fill(85);
        }

        private static void Bucket_AlmostFull(object sender, EventArgs e)
        {
            Console.WriteLine("The bucket is almost full");
        }

        private static void Bucket_Full(object sender, EventArgs e)
        {
            Console.WriteLine("The bucket is full");
        }

   
    }
}
