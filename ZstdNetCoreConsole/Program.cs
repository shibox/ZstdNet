using System;
using System.Diagnostics;
using System.Linq;
using ZstdNetCore;

namespace ZstdNetCoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Zstd();
        }

        public static void Zstd()
        {
            int[] array = Enumerable.Range(0, 10000000).ToArray();
            byte[] sourceData = new byte[array.Length * 4];
            Buffer.BlockCopy(array, 0, sourceData, 0, sourceData.Length);
            using (var compressor = new Compressor())
            {
                Stopwatch w = Stopwatch.StartNew();
                byte[] compressedData = compressor.Wrap(sourceData);
                Console.WriteLine($"cost:{w.ElapsedMilliseconds}");
                w = Stopwatch.StartNew();
                byte[] original = new Decompressor().Unwrap(compressedData);
                Console.WriteLine($"cost:{w.ElapsedMilliseconds}");

                Console.WriteLine(
                    $"sourceData Length:{original.Length}\n" +
                    $"compressedData Length:{compressedData.Length}\n" +
                    $"compress Rate:{(float)compressedData.Length * 100 / original.Length}%");
            }
            Console.ReadLine();
        }
    }
}
