﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP2007_FinalProject_HastyTaste.ViewModels
{
    public class ShoppingCartRemoveViewModel
    {
        public virtual string Message { get; set; }
        public virtual decimal CartTotal { get; set; }
        public virtual int CartCount { get; set; }
        public virtual int ItemCount { get; set; }
        public virtual int DeleteId { get; set; }
    }
}