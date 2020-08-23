using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Igreja.gui.util
{
    class Utils
    {
        public static int? tryParseToInt(String str)
        {
            try
            {
                return int.Parse(str);

            }
            catch (FormatException)
            {

                return null;
            }
        }
    }
}
