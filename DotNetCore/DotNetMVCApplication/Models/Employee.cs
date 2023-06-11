

using Microsoft.EntityFrameworkCore;

namespace DotNetMVCApplication.Models
{
    public class Employee
    {
        public long ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public decimal Salary { get; set; }
    }

    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
    public class EmployeeListViewModel
    {
        public List<Employee> EmployeesList { get; set; }
    }

}
