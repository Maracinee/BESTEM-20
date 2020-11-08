using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BESTEM_20.Data
{
    public interface IFileSave
    {
        Task SaveAs(string fileName, string data, string type = "text/plain;charset=utf-8");
    }
}
