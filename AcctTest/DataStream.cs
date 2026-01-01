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
      if (Directory.Exists(GlobVar.ExtLoc+"/AcctTest"))
      {
        Console.WriteLine($"{GlobVar.ExtLoc}/AcctTest Exists!");
      }
      else
      {
        Console.WriteLine($"{GlobVar.ExtLoc}/AcctTest Does not exist!");
        Thread.Sleep(20);
        Console.WriteLine($"Creating {GlobVar.ExtLoc}/AcctTest");
        Directory.CreateDirectory(GlobVar.ExtLoc+"/AcctTest");
      }
    }
  }
}
