using Npgsql;
using StoreApp.DataAccsess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.View
{
    public static class DataDisplayer
    {

        public static void PalletsDataOutputBySql(string sql)
        {
            using var con = new NpgsqlConnection(ConnectionInfo.ConnectionString);
            con.Open();
            using var cmd = new NpgsqlCommand(sql, con);
            using NpgsqlDataReader rdr = cmd.ExecuteReader();

            Console.WriteLine("{0,10}\t{1,10}\t{2,10}\t{3,10}\t{4,10}\t{5,10}\t{6,10}\n" , "id_паллеты",  "ширина", "высота", "глубина", "вес", "объем", "срок годности");
            while (rdr.Read())
            {
                Console.WriteLine("{0,10}\t{1,10}\t{2,10}\t{3,10}\t{4,10}\t{5,10}\t{6,10}", rdr.GetDouble(0), rdr.GetDouble(1), rdr.GetDouble(2), rdr.GetDouble(3), rdr.GetDouble(4), rdr.GetDouble(5), Convert.ToDateTime(rdr[6]).ToString("dd/MM/yyyy"));
            }
            Console.WriteLine();
        }
        public static void BooksDataOutputBySql(string sql)
        {
            using var con = new NpgsqlConnection(ConnectionInfo.ConnectionString);
            con.Open();
            using var cmd = new NpgsqlCommand(sql, con);
            using NpgsqlDataReader rdr = cmd.ExecuteReader();

            Console.WriteLine("{0,10}\t{1,10}\t{2,10}\t{3,10}\t{4,5}\t{5,10}\t{6,10}\t{7,10}\t{8,10}\n", "id_коробки","id_паллеты", "дата производства",  "ширина", "высота", "глубина", "вес", "объем", "срок годности");
            while (rdr.Read())
            {
                Console.WriteLine("{0,10}\t{1,10}\t{2,10}\t{3,15}\t{4,10}\t{5,10}\t{6,10}\t{7,10}\t{8,10}", rdr.GetDouble(0), rdr.GetDouble(1), Convert.ToDateTime(rdr[2]).ToString("dd/MM/yyyy"), rdr.GetDouble(3), rdr.GetDouble(4), rdr.GetDouble(5), rdr.GetDouble(6), rdr.GetDouble(7), Convert.ToDateTime(rdr[8]).ToString("dd/MM/yyyy"));
            }
            Console.WriteLine();
        }



    }
}
