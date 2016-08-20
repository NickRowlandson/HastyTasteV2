/**
 * @author: Nick Rowlandson & Tim Harasym
 * @description: Final Assignment - MVC Restaurant with Cart
 * @date: August 19 2016
 * @version: 0.0.3 
 */
namespace COMP2007_FinalProject_HastyTaste.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MenuModel : DbContext
    {
        public MenuModel()
            : base("name=MenuModel")
        {
        }

        public virtual DbSet<MenuItem> MenuItems { get; set;}
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    }
}
