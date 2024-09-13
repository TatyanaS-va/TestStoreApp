using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Models
{
    public class Pallet: Items
    {
        public List<Box> Boxes = new List<Box>();
        public Pallet( double width, double height, double depth)
        {
            Width = width;
            Height = height;
            Depth = depth;
            Volume = CalculateVolume();
            ExpirationDate = CalculateExpirationDate();
            Weight = CalculateWeight();
        }
        public override double? CalculateVolume()
        {
            return Boxes.Sum(item => item.Volume) + Width * Height * Depth;
        }
        public override DateOnly? CalculateExpirationDate()
        {
            if (Boxes.Count != 0) return Boxes.OrderBy(d => d.ExpirationDate).FirstOrDefault().ExpirationDate;
            else return null;
        }
        public double? CalculateWeight()
        {
            return Boxes.Sum(item => item.Weight) + 30;
        }
        public bool AddBox(Box box)
        {
            if (box.Width < Width && box.Depth < Depth)
            {
                Boxes.Add(box);
                box.PalletId = Id;
                return true;
            }
            else
            {
                Console.WriteLine($"Размер коробки №{box.Id} превышает размер паллеты №{Id}. Данная коробка не будет добавлена.\n");
                return false;
            }
        }    
    }
}
