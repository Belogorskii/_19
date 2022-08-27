/*Модель компьютера  характеризуется  кодом  и  названием  марки компьютера, типом  процессора, частотой  
работы  процессора, объемом оперативной памяти, объемом жесткого диска, объемом памяти видеокарты, 
стоимостью компьютера в условных единицах и количеством экземпляров, имеющихся в наличии. Создать 
список, содержащий 6-10 записей с различным набором значений характеристик.

Определить:
-все компьютеры с указанным процессором. Название процессора запросить у пользователя;   +
-все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;  +
-вывести весь список, отсортированный по увеличению стоимости;                           +
-вывести весь список, сгруппированный по типу процессора;                                +
-найти самый дорогой и самый бюджетный компьютер;                                        +    -
-есть ли хотя бы один компьютер в количестве не менее 30 штук?*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            {
                new Employee() { Kod = 101002346, BrandName = "ASUS", ProcessorType = "i5", ProcessorFrequency = 1000, AmountRAM = 16, HarddiskCapacity = 1000, VideocardVolume=1050, Price=29000, Amount=17}; 
                new Employee() { Kod = 436604564, BrandName = "SAMSUNG", ProcessorType = "i6", ProcessorFrequency = 1500, AmountRAM = 8, HarddiskCapacity = 1000, VideocardVolume=950, Price=30000, Amount=48}; 
                new Employee() { Kod = 346636346, BrandName = "ASER", ProcessorType = "i5", ProcessorFrequency = 1400, AmountRAM = 16, HarddiskCapacity = 2000, VideocardVolume=1050, Price=39000, Amount=34}; 
                new Employee() { Kod = 436623643, BrandName = "ASER", ProcessorType = "i3", ProcessorFrequency = 1000, AmountRAM = 32, HarddiskCapacity = 1000, VideocardVolume=1050, Price=50000, Amount=12}; 
                new Employee() { Kod = 679569559, BrandName = "ASUS", ProcessorType = "i7", ProcessorFrequency = 1300, AmountRAM = 16, HarddiskCapacity = 1000, VideocardVolume=950, Price=66000, Amount=3}; 
                new Employee() { Kod = 347694949, BrandName = "SAMSUNG", ProcessorType = "i7", ProcessorFrequency = 1000, AmountRAM = 4, HarddiskCapacity = 2000, VideocardVolume=950, Price=35000, Amount=45}; 
                new Employee() { Kod = 262473754, BrandName = "ASUS", ProcessorType = "i6", ProcessorFrequency = 1200, AmountRAM = 16, HarddiskCapacity = 1000, VideocardVolume=1950, Price=70000, Amount=29}; 
                new Employee() { Kod = 224677835, BrandName = "SAMSUNG", ProcessorType = "i9", ProcessorFrequency = 1000, AmountRAM = 64, HarddiskCapacity = 2000, VideocardVolume=1950, Price=90000, Amount=23}; 
            }
            Console.WriteLine("Введите название процесора");
            string processorType = Console.ReadLine();
            List<Employee> employees1 = employees.Where(x => x.ProcessorType == processorType).ToList();
            Print(employees1);

            Console.WriteLine("Введите объем ОЗУ");
            int amountRAM = Convert.ToInt32(Console.ReadLine());
            List<Employee> employees2 = employees.Where(x => x.AmountRAM == amountRAM).ToList();
            Print(employees2);
            Console.ReadLine();

            List<Employee> employees3 = employees.OrderBy(x => x.Price).ToList();
            Print(employees3);
            
            IEnumerable<IGrouping<string, Employee>> employees4 = employees.GroupBy(x => x.ProcessorType);
            foreach(IGrouping<string, Employee> employee in employees4)
            {
                Console.WriteLine(gr.Key);
                foreach(Employee e in gr)
                {
                    Console.WriteLine($"{e.Kod} {e.BrandName} {e.ProcessorType} {e.ProcessorFrequency} {e.AmountRAM} {e.HarddiskCapacity} {e.VideocardVolume} {e.Price} {e.Amount}");
                }
            }
            Employee employee5 = employees.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{employee5.Kod} {employee5.BrandName} {employee5.ProcessorType} {employee5.ProcessorFrequency} {employee5.AmountRAM} {employee5.HarddiskCapacity} {employee5.VideocardVolume} {employee5.Price} {employee5.Amount}");

            Employee employee6 = employees.OrderBy (x => x.Price).FirstOrDefault();
            Console.WriteLine($"{employee6.Kod} {employee6.BrandName} {employee6.ProcessorType} {employee6.ProcessorFrequency} {employee6.AmountRAM} {employee6.HarddiskCapacity} {employee6.VideocardVolume} {employee6.Price} {employee6.Amount}");

            Console.WriteLine(employees.Any(x => x.Amount > 30));
            Console.ReadKey();
        }
        static void Print(List<Employee> employees)
        {
            foreach(Employee e in employees)
            {
                Console.WriteLine($"{e.Kod} {e.BrandName} {e.ProcessorType} {e.ProcessorFrequency} {e.AmountRAM} {e.HarddiskCapacity} {e.VideocardVolume} {e.Price} {e.Amount}");
            }
            Console.WriteLine();
        }
    }
}