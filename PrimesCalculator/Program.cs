using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Numerics;
using System.IO;
using System.Threading.Tasks;

namespace PrimesCalculator
{
    class Program
    {
        const string FilePath = @"C:\code\bignumber.txt";
        const int UpperRange = 1000000;
        static void Main(string[] args)
        {
            BigInteger product = 1;
            var primes = Enumerable.Range(1, UpperRange).Where(x => Primality.IsPrime(x));
            var timeTakenSerial = TimeKeeper.Time(() =>
            {
                primes.ForEach(x => product *= x);
            });
            product = 1;
            primes = Enumerable.Range(1, UpperRange).Where(x => Primality.IsPrime(x));
            var timeTakenParallel = TimeKeeper.Time(() => Parallel.ForEach<int>(primes, x => product *= x));
            
            Console.WriteLine("Time Taken Serial: " + timeTakenSerial);
            Console.WriteLine("Time Taken Parallel: " + timeTakenParallel);
            Console.ReadKey();
            WriteToFile(product);
            Console.WriteLine(product);
            Console.ReadLine();
        }

        private static void WriteToFile(BigInteger product)
        {
            if (File.Exists(FilePath))
                File.Delete(FilePath);
            using(var  file = File.CreateText(FilePath))
            {
                file.Write(product.ToString());
                file.Close();
            }
        }
    }
}
