using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CSE422_Lab2.Models;

namespace CSE422_Lab2.Data
{
    public class CSE422_Lab2Context : DbContext
    {
        public CSE422_Lab2Context (DbContextOptions<CSE422_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<CSE422_Lab2.Models.CategoryModel> CategoryModel { get; set; } = default!;
        public DbSet<CSE422_Lab2.Models.DeviceModel> DeviceModel { get; set; } = default!;
        public DbSet<CSE422_Lab2.Models.UserModel> UserModel { get; set; } = default!;

    }
}
