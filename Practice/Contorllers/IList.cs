using Practice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Contorllers
{
    public class IList
    {
        //申明一个静态的泛型集合  泛型 IList<T>  T：代表放入的类型  这里放入的是模型类
        private static IList<StoreModel> _storeList = null;
    }
}
