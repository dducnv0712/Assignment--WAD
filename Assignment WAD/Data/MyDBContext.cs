using Assignment_WAD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentManage.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext():base("name=T2009MTest")
        {

        }
        public DbSet<StudentLate> StudentLate { get; set; }
    }
}