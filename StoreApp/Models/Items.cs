using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Models
{
    public abstract class Items
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set;  }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }
        public double? Weight { get; set; }
        public double? Volume { get; set; }
        public DateOnly? ExpirationDate { get; set; }
        public abstract double? CalculateVolume();
        public abstract DateOnly? CalculateExpirationDate();


    }
}
