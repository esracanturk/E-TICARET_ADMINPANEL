using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicaretMVC.Models
{
    public class Store
    {
        public int groupid { get; set; }
        [Required(ErrorMessage ="Departman adı boş geçilemez")]
        public string groupname { get; set; }
    }
}
