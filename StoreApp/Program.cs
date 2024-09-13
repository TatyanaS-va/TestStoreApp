using Microsoft.EntityFrameworkCore;
using StoreApp.Models;
using Npgsql;
using StoreApp.View;

//обновление данных в БД
using (ApplicationContext db = new ApplicationContext())
{
     
    int count = 0;
    bool boxesInStore;
    Random rnd = new Random();
    var boxes = db.Boxes.ToList();
   

    foreach (Box b in boxes)
    {
        b.Volume = b.CalculateVolume();
        b.ExpirationDate = b.CalculateExpirationDate();
        db.Boxes.Update(b);
    }

    boxesInStore = boxes.Count > 0 ? true : false;

    var pallets = db.Pallets.ToList();

    foreach (Pallet p in pallets)
    {
        if (boxesInStore)
        {    
            //заполнение паллет рандомным количеством коробок
            for (int i = 0; i < rnd.Next(1, 3); i++)
            {
                if (count < boxes.Count())
                {
                    if (p.AddBox(boxes[count])) {

                        boxes[count].PalletId = p.Id;
                        db.Boxes.Update(boxes[count]);
                        count++;
                    }
                    else {
                        boxes.Add(boxes[count]);
                        boxes.RemoveAt(count);
                    }
                }
                else
                {
                    boxesInStore = false;
                    break;
                }
            }        
        }
        else break;
        p.Volume = p.CalculateVolume();
        p.Weight = p.CalculateWeight();
        p.ExpirationDate = p.CalculateExpirationDate();
        db.Pallets.Update(p);
        db.SaveChanges();
    }
    db.SaveChanges();
}
//Вывод данных по заданию 

DataDisplayer.BooksDataOutputBySql(@"SELECT * FROM ""Boxes"" WHERE ""PalletId"" IS NOT NULL");

DataDisplayer.PalletsDataOutputBySql(@"SELECT * FROM ""Pallets""  WHERE  ""ExpirationDate"" IS NOT NULL");

Console.WriteLine("Вывести 3 паллеты, которые содержат коробки с наибольшим сроком годности, отсортированные по возрастанию объема.\n");

DataDisplayer.PalletsDataOutputBySql(@"SELECT * FROM
                (SELECT * FROM ""Pallets"" 
                WHERE  ""ExpirationDate"" IS NOT NULL
                ORDER BY  ""ExpirationDate"" DESC 
                LIMIT 3)
                ORDER BY ""Volume"" ASC;");

Console.WriteLine("Сгруппировать все паллеты по сроку годности, отсортировать по возрастанию срока годности, в каждой группе отсортировать паллеты по весу.\n");

DataDisplayer.PalletsDataOutputBySql(@"
                SELECT * FROM ""Pallets"" 
                WHERE  ""ExpirationDate"" IS NOT NULL
                ORDER BY  ""ExpirationDate"", ""Weight"";");