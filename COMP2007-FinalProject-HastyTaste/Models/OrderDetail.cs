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
    public class OrderDetail
    {
        public virtual int OrderDetailId { get; set; }
        public virtual int OrderId { get; set; }
        public virtual int ItemId { get; set; }
        public virtual int Quantity { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual MenuItem MenuItem { get; set; }
        public virtual Order Order { get; set; }
    }
}