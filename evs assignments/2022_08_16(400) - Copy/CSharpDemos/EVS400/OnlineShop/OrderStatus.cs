using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS400.OnlineShop
{
    //An enum is a named series of related constants 
    enum OrderStatus //: byte
    {
        Pending,
        Confirm,
        InProcess,
        InTransit,
        Delivered,
        Cancelled
    }
}
