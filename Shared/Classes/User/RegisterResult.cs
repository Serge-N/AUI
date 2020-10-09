using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AUI.Shared
{
    public class RegisterResult
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
