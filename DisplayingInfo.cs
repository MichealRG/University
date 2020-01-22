using System;
using System.Collections.Generic;
using System.Text;

namespace Zzadanie2
{
    interface IDisplayingInfo
    {
        (string, string, string) GetDefaultInfo();
    }
}
