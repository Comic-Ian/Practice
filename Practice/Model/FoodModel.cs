using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Model
{
    public class FoodModel
    {
        //食物名字
        public string FoodName { get; set; }

        //食物种类
        public string FoodKind { get; set; }

        //食物评价
        public Evaluate FoodEvaluate { get; set; }
    }
}
