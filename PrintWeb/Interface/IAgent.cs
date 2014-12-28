using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintWeb.Interface
{
    public interface IAgent
    {
        string Name { get; set; }

        string Url { get; set; }

        TimeSpan DeliveringTime { get; set; }

    }
}
