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

    public static String UserFile = ExtLoc+"/user.txt";
    public static string PassFile = ExtLoc+"/pass.txt";
  }
}
