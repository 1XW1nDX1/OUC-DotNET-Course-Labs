using Record;
using System;
using System.Collections.Generic;
using System.Text;

namespace Record
{
    internal abstract class RecordBuffer : IRecordDevice
    {
        private string _serial;
        public int Capacity { get; private set; }
        public int Used;

        protected abstract bool Write(string[] records);
        protected abstract string[] Read(int count);

        public void Print()
        {
            Console.WriteLine($"设备序列号: {_serial} | 容量: {Capacity} | 已用条数: {Used}");
        }

    }

    internal class SensorBuffer : RecordBuffer
    {

    }

    internal class BackupBuffer : RecordBuffer
    {
    }
}

/*
IRecordDevice 接口 只读属性 string Serial { get; }；方法 void Print()
RecordBuffer 抽象类
实现 IRecordDevice；私有字段 _serial；只读容量 Capacity 与已用条数Used；实现Print()；声明 abstract bool Write(string[] records) 和 abstract string[] Read(int count)
SensorBuffer 派生类 增加采样频率 SampleRate；实现两个抽象方法，输出带“采集缓存”标签的读写提示BackupBuffer 派生类 增加备份位置 Location；实现两个抽象方法，输出带“备份缓存”标签的读写提示
*/
