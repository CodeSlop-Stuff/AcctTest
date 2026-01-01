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
      DataStream.checkdir();
      DataStream.checkdir();

      Thread.Sleep(999999999);
    }
  }
}
