using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DatabaseCart.Models
{
    public class Items
    {
        [Key]
        public int ItemsId { get; set; }
        public Product Product{get;set;}

        public int Quantity
        {
            get;
            set;
        }

    }
}
