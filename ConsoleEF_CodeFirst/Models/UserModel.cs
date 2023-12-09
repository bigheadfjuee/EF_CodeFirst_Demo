using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEF_CodeFirst.Models
{
    public partial class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

    }
}
