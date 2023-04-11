using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaAppTest.Models;

public class SelectRole
{
    public Role Role { get; set; }
}

public enum Role
{
    Administrator,
    Guest,
    User
}
