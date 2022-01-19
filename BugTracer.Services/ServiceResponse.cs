using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracer.Services
{
    public class ServiceResponse <T>
    {
        public bool IsSucess { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public T Data { get; set; }
    }
}
