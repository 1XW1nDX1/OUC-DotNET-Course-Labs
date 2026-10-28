using System;
using System.Collections.Generic;
using System.Text;

namespace Record
{
    internal interface IRecordDevice
    {
        string Serial { get; }
        void Print();
    }
}
