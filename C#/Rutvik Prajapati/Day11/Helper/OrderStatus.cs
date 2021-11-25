using System;
using System.Collections.Generic;
using System.Text;

namespace Day11Task.Helper
{
    enum OrdersStatus
    {
        Pending=1,
        Conformed,
        Canceled,
        Shipped,
        ReadyForDelivery
    }

    enum PaymentStatus
    {
        Success=1,
        Fail
    }
    
}
