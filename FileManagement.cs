using BenchmarkDotNet.Attributes;

namespace benchmark_analysis;

public class FileManagement
{
   public string filePath { get; set; }

   public FileManagement()
   {
      filePath = @"C:\Files\ratings.csv"; 
   }

   [Benchmark]
   public decimal Run1()
   {
      var lines = File.ReadAllLines(filePath);
      int quantity = 0;
      decimal sum = 0; 

      foreach (var line in lines)
      {
         var separated = line.Split(","); 

         if (int.Parse(separated[1]) == 111)
         {
            sum += decimal.Parse(separated[2]);
            quantity++; 
         }
      }
      
      return sum / quantity;
   }
}