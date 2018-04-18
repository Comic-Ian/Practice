using Practice.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Contorllers
{
    
    //写一个抽象的接口
    public interface IFunc
    {
        void SaveFood(FoodModel food);

        void SaveStore(StoreModel store);

    }

    //将抽象的接口实例化，以便于调用
    public class Func : IFunc
    {
        public void SaveFood(FoodModel food)
        {
            //拼接字符串
            string FoodValues = string.Format("食物名称：{0}  食物种类：{1}  食物评价：{2}", food.FoodName, food.FoodKind, food.FoodKind);
            


            File.AppendAllText("E:\\123.txt", FoodValues);
        }

        public void SaveStore(StoreModel store)
        {
            string StoreValues = string.Format("店铺名称：{0}  店铺地址：{1}  店铺评价：{2}", store.StoreName, store.StoreSite, store.StoreEvaluate);
            File.AppendAllText("E:\\123.txt", StoreValues);
        }
    }
}
