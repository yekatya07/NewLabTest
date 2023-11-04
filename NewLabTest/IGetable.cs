using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IGetable
    {
        (string, string, string) GetInput(string f, string s, string t);
    }
}
