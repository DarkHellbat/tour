﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public string PStatusName { get; set; }
        public override string ToString()
        {
            return PStatusName;
        }
    }
}
