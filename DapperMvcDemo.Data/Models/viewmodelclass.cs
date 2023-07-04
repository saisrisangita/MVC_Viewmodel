using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperMvcDemo.Data.Models
{
    public class viewmodelclass
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
