using PrintWeb.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintWeb.Interface
{
    interface ISellingInformation
    {

        long BuyableSize { get; set; }


        CustomerEntities CustomerEntity { get; set; }
    }
}
