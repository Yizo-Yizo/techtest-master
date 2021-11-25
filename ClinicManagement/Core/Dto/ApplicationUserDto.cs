using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicManagement.Core.Dto
{
    public class ApplicationUserDto
    {
        public string Name { get; set; }

        public bool? IsActive { get; set; }
    }
}