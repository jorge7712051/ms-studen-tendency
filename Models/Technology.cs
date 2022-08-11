using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ms_studentTendency.Models
{
    public class Technology
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string technology { get; set; }
        [Required]
        public Boolean active{ get; set; }

        public virtual ICollection<Category> Categories { get; set; }

        public virtual ICollection<User> Users { get; set; }


    }
}
