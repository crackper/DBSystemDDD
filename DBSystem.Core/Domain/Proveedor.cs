using System;
using System.Collections.Generic;

namespace DBSystem.Core.Domain
{
    public partial class Proveedor:BaseEntity
    {
        public string razonSocial { get; set; }
        public string ruc { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
    }
}
