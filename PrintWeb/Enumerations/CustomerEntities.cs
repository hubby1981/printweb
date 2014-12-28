using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintWeb.Enumerations
{
    public enum CustomerEntities
    {
        B2C = 0, // Business to Normal Customers
        B2B = 1, // Business to Other Companies
        B2S = 2, // Business to other Shops or Reseller
        B2L = 3  // Business to other Logistik Partners
    }
}
