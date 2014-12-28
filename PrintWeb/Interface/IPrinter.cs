﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintWeb.Interface
{
    interface IPrinter
    {
        string Name { get; set; }

        string Id { get; set; }

        string EAN { get; set; }

        string UID { get; set; }


    }
}
