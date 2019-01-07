using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTest.Models
{
    public interface IData<T>
    {
         T Data { get;  }
    }
}
