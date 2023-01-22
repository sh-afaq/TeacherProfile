using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TeacherProfile.Models
{
    public class CrudContext : DbContext
    {
        public CrudContext() : base("TeacherProfileString")
        {

        }
        public DbSet<Teacher> teachers { get; set; }
    }
}