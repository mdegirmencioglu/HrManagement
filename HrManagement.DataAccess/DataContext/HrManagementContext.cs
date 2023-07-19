using HrManagement.Entity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrManagement.DataAccess.DataContext
{
    public class HrManagementContext:IdentityDbContext
    {
        public HrManagementContext (DbContextOptions options )
            : base (options)
        { 
                    
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeLeaveAllocation> EmployeeLeaveAllocations { get; set; }
        public DbSet<EmployeeLeaveRequest> EmployeeLeaveRequests { get; set; }
        public DbSet<EmployeeLeaveType> EmployeeLeaveTypes { get; set; }
    }
}
