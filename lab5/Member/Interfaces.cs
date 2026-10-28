using System;
using System.Collections.Generic;
using System.Text;

namespace Member
{
    internal interface IShift
    {
        void AttendShift(string zone); //参加指定区域的值班
    }

    internal interface IRepair
    {
        void Repair(string deviceName); //处理指定设备的维修任务
    }
}
