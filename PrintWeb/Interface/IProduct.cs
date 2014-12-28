using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintWeb.Interface
{
    interface IProduct
    {
        float Price { get; set; }

        float Discount { get; set; }

        long PossibleSize { get; set; }

        IEnumerable<IProduct> Products { get; set; }

        IEnumerable<IDevice> Devices { get; set; }
    }
}
