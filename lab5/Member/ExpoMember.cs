using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace Member
{
    internal class ExpoMember
    {
        private uint _serviceYear;
        public string Name;
        public string Zone;

        public ExpoMember(string name, string zone, uint serviceYear)
        {
            Name = name;
            Zone = zone;
            _serviceYear = serviceYear;
        }
        public virtual void Print()
        {
            Console.WriteLine($"姓名: {Name} | 区域: {Zone} | 服务年份: {_serviceYear}");
        }
    }

    internal class Guide : ExpoMember, IShift
    {
        public string Language;

        public Guide(string name, string zone, uint serviceYear, string language) : base(name, zone, serviceYear)
        {
            Language = language;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"讲解语言: {Language}");
        }

        public void AttendShift(string zone)
        {
            Console.WriteLine($"{Name} 正在 {zone} 区域值班。");
        }
    }

    internal class Technician : ExpoMember, IShift, IRepair
    {
        private string _specialty;

        public Technician(string name, string zone, uint serviceYear, string specialty) : base(name, zone, serviceYear)
        {
            _specialty = specialty;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"专长: {_specialty}");
        }

        public void AttendShift(string zone)
        {
            Console.WriteLine($"{Name} 正在 {zone} 区域值班。");
        }

        public void Repair(string deviceName)
        {
            Console.WriteLine($"{Name} 正在处理 {deviceName}。");
        }
    }
}
