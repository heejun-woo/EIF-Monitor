using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIF_Monitor
{
    public partial class Common
    {
        public Func<string, string> getLogDir = (x) => $"D:\\Logs\\{x}\\ezControl\\System\\VARIABLE_TRACE";
    }
}
