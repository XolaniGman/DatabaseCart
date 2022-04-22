using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DatabaseCart.Models
{
    public class Product
    {
        [Key]
        public string Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public double Price
        {
            get;
            set;
        }

        public string Photo
        {
            get;
            set;
        }

        //internal Product find(string id)
        //{
        //    return Single(p => p.Id.Equals(id));
        //}
    }
}
