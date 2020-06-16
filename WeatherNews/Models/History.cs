using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherNews.Models
{
    [Table("History")]
    public class History
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("info")]
        public string Info { get; set; }

    }
}
