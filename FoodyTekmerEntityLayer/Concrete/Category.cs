﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyTekmerEntityLayer.Concrete
{
    public class Category
    {// internal sadece bulunduğu katmandan erişim sağlar 
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
