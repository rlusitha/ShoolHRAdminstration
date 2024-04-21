using HRAdministrationAPI;

namespace ShoolHRAdminstration
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal totalSalaries = 0;
            List<IEmployee> employees = new List<IEmployee>();

            SeedData(employees);

            //foreach (IEmployee employee in employees)
            //{
            //    totalSalaries += employee.Salary;
            //}

            //Console.WriteLine($"Total Annual Salaries (Including bonus): {totalSalaries}");
            Console.WriteLine($"Total Annual Salaries (Including bonus): {employees.Sum(e => e.Salary)}");
            Console.ReadKey();
        }

        public static void SeedData(List<IEmployee> employees)
        {
            IEmployee teacher1 = new Teacher
            {
                Id = 1,
                FirstName = "Lusitha",
                LastName = "Ranathunga",
                Salary = 150000
            };

            employees.Add(teacher1);

            IEmployee teacher2 = new Teacher
            {
                Id = 2,
                FirstName = "Danushka",
                LastName = "Jayawickrama",
                Salary = 50000
            };

            employees.Add(teacher2);

            IEmployee headOfDepartment = new HeadOfDepartment
            {
                Id = 3,
                FirstName = "Abhinu",
                LastName = "Ranathunga",
                Salary = 500000
            };

            employees.Add(headOfDepartment);

            IEmployee deputyHeadMaster = new DeputyHeadMaster
            {
                Id = 4,
                FirstName = "Roshan",
                LastName = "Mahanama",
                Salary = 20000
            };

            employees.Add(deputyHeadMaster);

            IEmployee headMaster = new HeadMaster
            {
                Id = 5,
                FirstName = "Mahinda",
                LastName = "Amaraweera",
                Salary = 30000
            };

            employees.Add(headMaster);
        }
    }
}
