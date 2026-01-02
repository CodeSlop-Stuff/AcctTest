using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace AcctTest
{
  internal class DataStream
  {
    public static void checkdir()
    {
      Console.WriteLine("Checking for System Files");

      // if directory doesnt exist, create directory.
      if (!Directory.Exists(GlobVar.ExtLoc))
      {
        Console.WriteLine($"{GlobVar.ExtLoc} Does not exist.");
        Console.WriteLine($"Creating {GlobVar.ExtLoc}.");
        Directory.CreateDirectory(GlobVar.ExtLoc);
      }

      // if username and password files do not exist, create them.
      if (!File.Exists(GlobVar.UserFile))
      {
        Console.WriteLine($"{GlobVar.UserFile} Does not exist.");
        Console.WriteLine($"Creating {GlobVar.UserFile}.");
        File.CreateText(GlobVar.UserFile);
      }
      if (!File.Exists(GlobVar.PassFile))
      {
        Console.WriteLine($"{GlobVar.PassFile} Does not exist.");
        Console.WriteLine($"Creating {GlobVar.PassFile}.");
        File.CreateText(GlobVar.PassFile);
      }
    }

    public static void WriteFile(string file, int line, string data)
    {
      StreamWriter Write = new StreamWriter(file);
      for (int i = 0; i < line-1; i++)
      {
        StreamWriter WriteTemp = new StreamWriter(GlobVar.ExtLoc + "/tmp.txt");
        WriteTemp.WriteLine(ReadFile(file, i));
        WriteTemp.Close();
        for (int j = 0; j < line - j; j++)
        {
          Write.Write(ReadFile(GlobVar.ExtLoc + "/tmp.txt", j));
        }
      }
      Write.WriteLine(data);
      Write.Close();
    } 

    public static string ReadFile(string file, int line)
    {
      string text = File.ReadLines(file).Skip(line-1).Take(1).First();
      return(text);
    }
  }
}
