using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcctTest
{
  internal class GlobVar
  {
    // Environment Variables
    public static string ExtLoc = Environment.ExpandEnvironmentVariables("%ProgramW6432%")+"/AcctTest";
    public static bool ExtLocFound = false;

    public static String UserFile = "";
    public static string PassFile = "";
  }
}
