using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Context
{
    public class fDatabase : DbContext
    {
        public fDatabase() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\KOSTA\Downloads\C#Pro\Lee_Movie\bin\Debug\Mymovie_Database.mdf"";Integrated Security=True;Connect Timeout=30")
        { 

        }

        public DbSet<Facility> facilities {get; set;}
    }
}