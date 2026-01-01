using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcctTest
{
  internal class GlobVar
  {
    public static string ExtLoc = Environment.ExpandEnvironmentVariables("%ProgramW6432%");
  }
}
