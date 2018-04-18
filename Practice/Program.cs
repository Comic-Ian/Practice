using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    static class Program
    {
        /// <summary>
        ///1.从前端记录两种信息: 食品信息 和 店铺信息
        ///2.根据不同的信息放入不同的集合
        ///3.提供一个功能:将存入的信息保存到本地文本
        ///4.要用分层的思想来构建你的程序结构
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Demo1());
        }
    }
}
