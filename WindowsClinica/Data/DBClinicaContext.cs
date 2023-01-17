using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WindowsClinica.Models;

namespace WindowsClinica.Data
{
    public class DBClinicaContext:DbContext
    {

        public DBClinicaContext() : base("KeyDB") { }

        public DbSet<Clinica> Clinicas { get; set; }

        public DbSet<Habitacion> Habitaciones { get; set; }


    }
}
