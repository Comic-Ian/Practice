using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Practice.Model;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Demo1 : Form
    {
        //申明两个个静态的泛型集合  泛型 IList<T>  T：代表放入的类型  这里放入的是模型类
        private static IList<StoreModel> _storeList = null;
        private static IList<FoodModel> _foodList = null;
        public Demo1()
        {
            //初始化窗体
            InitializeComponent();
            //初始化店铺、食物存放集合
            _storeList = new List<StoreModel>();
            _foodList = new List<FoodModel>();
            //初始化窗体的评价集合到控件ComboBox
            InitEvaluate();
        }

        private void InitEvaluate()
        {
            //获取定义的评价枚举类型
            Type EvaluateType = typeof(Evaluate);

            //获取枚举的名字数组
            string[] evaluatenames = Enum.GetNames(EvaluateType);

            //将获取到的名字分别加入到控件中
            for (int i = 0; i <evaluatenames.Length;i++)
            {
                CmbFood.Items.Add(evaluatenames[i]);
                CmbStore.Items.Add(evaluatenames[i]);
            }
            //设置下拉框默认选中第一个
            CmbFood.SelectedIndex = 0;
            CmbStore.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取数据
            string storeName = TbStoreNa.Text.ToString();
            if (string.IsNullOrEmpty(storeName))
            {
                MessageBox.Show("店铺名称不能为空");
                return;
            }
            string storeSite = TbStoreSi.Text.ToString();
            if (string.IsNullOrEmpty(storeSite))
            {
                MessageBox.Show("店铺地址不能为空");
                return;
            }
            string foodName = TbFoodNa.Text.ToString();
            if (string.IsNullOrEmpty(foodName))
            {
                MessageBox.Show("食物名称不能为空");
                return;
            }
            string foodKind = TbFoodKi.Text.ToString();
            if (string.IsNullOrEmpty(foodKind))
            {
                MessageBox.Show("食物种类不能为空");
                return;
            }

            string storeEvaluate = CmbStore.SelectedItem.ToString();
            string foodEvaluate = CmbFood.SelectedItem.ToString();

            StoreModel store = new StoreModel();
            store.StoreName = storeName;
            store.StoreSite = storeSite;
            if (storeEvaluate == "五星")
            {
                store.StoreEvaluate = Evaluate.五星;
            }
            else if (storeEvaluate == "四星")
            {
                store.StoreEvaluate = Evaluate.四星;
            }
            else if (storeEvaluate == "三星")
            {
                store.StoreEvaluate = Evaluate.三星;
            }
            else if (storeEvaluate == "二星")
            {
                store.StoreEvaluate = Evaluate.二星;
            }
            else if (storeEvaluate == "一星")
            {
                store.StoreEvaluate = Evaluate.一星;
            }

            FoodModel food = new FoodModel();
            food.FoodName = foodName;
            food.FoodKind = foodKind;
            if (foodEvaluate == "五星")
            {
                food.FoodEvaluate = Evaluate.五星;
            }
            else if (foodEvaluate == "四星")
            {
                food.FoodEvaluate = Evaluate.四星;
            }
            else if (foodEvaluate == "三星")
            {
                food.FoodEvaluate = Evaluate.三星;
            }
            else if (foodEvaluate == "二星")
            {
                food.FoodEvaluate = Evaluate.二星;
            }
            else if (foodEvaluate == "一星")
            {
                food.FoodEvaluate = Evaluate.一星;
            }

            //加入到集合
            _storeList.Add(store);
            _foodList.Add(food);

            //将两个集合存储为本地txt文件


            MessageBox.Show("成功");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TbFoodKi.Text = "";
            TbFoodNa.Text = "";
            TbStoreNa.Text = "";
            TbStoreSi.Text = "";
        }
    }
}
