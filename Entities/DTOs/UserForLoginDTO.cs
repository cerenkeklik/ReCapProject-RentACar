using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class UserForLoginDTO :IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
