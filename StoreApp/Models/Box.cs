using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Models
{
    public class Box : Items
    { 
        
        public int? PalletId { get; set; }
        public DateOnly ProductionDate { get; set; }

        public Box( double width,double height, double depth, double? weight, DateOnly productionDate)
        {     
            Width = width;
            Height = height;
            Depth = depth;       
            Weight = weight;
            ProductionDate = productionDate;
            Volume = CalculateVolume();
            ExpirationDate = CalculateExpirationDate();
        }

        public override double? CalculateVolume()
        {
            return Width * Height * Depth;
        }
        public override DateOnly? CalculateExpirationDate()
        {
            return ProductionDate.AddDays(100);
        }
       
    }
}
