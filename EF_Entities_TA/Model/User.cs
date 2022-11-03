using Microsoft.EntityFrameworkCore;
using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Entities_TA.Model
{
    public class User
    {
        public int UserId { get; set; }
        [MaxLength(30)]
        [Index(IsUnique =true)]
        [Unique]
        public string UserName { get; set; }
        [MaxLength(12)]
        public string Password { get; set; }
    }
}
