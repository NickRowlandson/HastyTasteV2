using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections;

/**
 * @author: Nick Rowlandson & Tim Harasym
 * @description: Final Assignment - MVC Restaurant with Cart
 * @date: August 19 2016
 * @version: 0.0.3 
 */
namespace COMP2007_FinalProject_HastyTaste.Models
{
    [Table("MenuItem")]
    public class MenuItem
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public MenuItem()
        {

        }

        /// <summary>
        /// This constructor takes one parameter - Title
        /// </summary>
        /// <param name="Title"></param>
        public MenuItem(string Title)
        {
            this.Title = Title;
        }

        [Key]
        public virtual int ID { get; set; }
        public virtual string Title { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string Description { get; set; }
        public virtual string ItemThumbnail { get; set; }
        public virtual string ItemImage { get; set; }
    }
}