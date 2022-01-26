using Storage.Data;
using Storage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Repo
{
    public class DataProvider
    {

        public readonly StorageContext _context;



        static public List<Product> GetAll(List<Product> productsList)
        {

            return productsList;
        }
    }
}