﻿using System.ComponentModel.DataAnnotations.Schema;

namespace KärraGamesCorner.Data.Models
{
    public class Product 
    {
        
        public int Id { get; set; }

        public string Name { get; set; } 

        public string Description { get; set; } 
        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }

        public int? GenreId { get; set; }

        public Genre? Genre { get; set; }

        public string ImageUrl { get; set; } = "/Resources/Images/Products/All_Images/default.jpg";

        public string Producer { get; set; }

        public bool IsPhysical { get; set; }

        public ICollection<Token> Tokens { get; set; }

        //måste ha för att kunna skapa junction table för cart
        public ICollection<ApplicationUser> UserCart { get; set; }
        
        public Product()
        {
            
        }

        public Product(int id, string name, string description, decimal price, Genre? genre, string producer,bool isPhysical, string imageUrl)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Genre = genre;
            ImageUrl = imageUrl;
            Producer = producer;
            IsPhysical = isPhysical;
            // Lägg if-sats här för att hämta befintlig lista om den finns.
            Tokens = new List<Token>();
            UserCart = new List<ApplicationUser>();


        }


    }
}
