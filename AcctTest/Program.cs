using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AcctTest
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Check for system files folder. Runs twice due to nature of the function.
      DataStream.checkdir();

      DataStream.WriteFile(GlobVar.UserFile, 1, "poop");
      DataStream.WriteFile(GlobVar.UserFile, 2, "sex");
      DataStream.WriteFile(GlobVar.UserFile, 3, "three");
      DataStream.WriteFile(GlobVar.UserFile, 4, "test");

      // Temporary exit, will be replaced later but for now ensures window doesnt close instantly
      Console.ReadKey();
    }
  }
}
