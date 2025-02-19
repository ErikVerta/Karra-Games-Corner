﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KärraGamesCorner.Data.Models
{
    public class CartProduct 
    {
        
        public ApplicationUser User { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public string ApplicationUserId { get; set; }
        public int ProductId { get; set; }
        public Guid? OrderId { get; set; }
        public Order Order { get; set; }

        public CartProduct()
        {

        }


    }
}
