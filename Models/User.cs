using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_eval.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; } = "Arturo";

        public string Email { get; set; } = "arturo@hotmail.com";

        public long Phone { get; set; }

        public UserKind Kind { get; set; }
    }
}