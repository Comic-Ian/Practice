﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Model
{
    public class StoreModel
    {
        //店铺名字
        public string StoreName { get; set; }

        //店铺地址
        public string StoreSite { get; set; }

        //店铺评价
        public Evaluate StoreEvaluate { get; set; }
    }
}
