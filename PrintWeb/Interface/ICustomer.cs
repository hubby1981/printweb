using PrintWeb.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintWeb.Interface
{
    public interface ICustomer
    {

        string Name { get; set; }

        string Id { get; set; }

        string InvoiceNumber { get; set; }

        string MailAddress { get; set; }

        CustomerEntities Enity { get; }
    }
}
