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
  }
}
