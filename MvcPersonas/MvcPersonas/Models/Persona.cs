﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcPersonas.Models
{
    public class Persona
    {
        public string DUI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
    }
    public class PersonaDBContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
    }
}