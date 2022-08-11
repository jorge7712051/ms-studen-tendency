using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ms_studentTendency.Models
{
    [Index(nameof(userEmail))]

    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        public string userEmail { get; set; }

        public string userPassword { get; set; }
        [Required]
        public DateTime userLastUpdate { get; set; }
        [Required]
        public Boolean userResponse { get; set; }
        [Required]
        public Boolean privacyPolicy { get; set; }

        public ICollection<UserResponse> userResponses { get; set; }

        public virtual ICollection<Technology> Technologies { get; set; }



    }
}
