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

        public virtual DbSet<MenuItem> MenuItems { get; set; }

    }
}
