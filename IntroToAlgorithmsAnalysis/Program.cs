using AlgorithmsAndDataStructLib;
using System.Diagnostics;

namespace IntroToAlgorithmsAnalysis
{
	internal partial class Program
	{
		static void Main(string[] args)
		{
			// 260 milliseconds for 1K
			// 13 seconds for 4K
			//  1.40  mins for 8k
			// 800 seconds for 16k

			//var ints = In.ReadInts("1Kints.txt").ToArray();

			//var watch = new Stopwatch();
			//watch.Start();


			//var triplets = ThreeSum.Count(ints);

			//watch.Stop();

			//Console.WriteLine($"The number of \"zero-some\" triplets: {triplets}");
			//Console.WriteLine($"Time taken: {watch.Elapsed}");

			//Console.ReadLine();



			var ints = In.ReadInts("1Kints.txt").ToArray();

			var watch = new Stopwatch();
			watch.Start();


			var triplets = ThreeSum.CountBetter(ints);

			watch.Stop();

			Console.WriteLine($"The number of \"zero-some\" triplets: {triplets}");
			Console.WriteLine($"Time taken: {watch.Elapsed}");
		}
	}
}