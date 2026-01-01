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
      if (GlobVar.ExtLocFound == false)
      {
        DataStream.checkdir();
      }

      // Temporary exit, will be replaced later but for now ensures window doesnt close instantly
      Console.ReadKey();
    }
  }
}
