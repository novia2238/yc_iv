﻿using System;
using System.Collections.Generic;

#nullable disable

namespace yc_interview.Models.DB
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
