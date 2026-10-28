namespace Member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 创建对象
            Guide guide = new Guide("张三", "海洋展区", 2026, "中文");
            Technician technician = new Technician("李四", "大气展区", 2026, "软件工程");

            Console.WriteLine("=============");
            guide.Print();
            technician.Print();


            Console.WriteLine("=============");

            ExpoMember[] members = { guide, technician };

            foreach (ExpoMember member in members)
            {
                member.Print();
            }

            Console.WriteLine("=============");

            IShift shift1 = guide;
            IShift shift2 = technician;

            shift1.AttendShift(guide.Zone);
            shift2.AttendShift(technician.Zone);

            Console.WriteLine("=============");

            IRepair repair = technician;
            repair.Repair("RTX GeForce 5090");
        }
    }
}
