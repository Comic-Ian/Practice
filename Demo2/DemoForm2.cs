using Demo2.Contorllers;
using Demo2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo2
{
    public partial class DemoForm2 : Form
    {
        public DemoForm2()
        {
            //初始化窗体
            InitializeComponent();
        }

        private void BtInsert_Click(object sender, EventArgs e)
        {
            //获取数据
            string peopleName = TbName.Text.ToString();
            string peopleSex = TbSex.Text.ToString();
            string peopleCardNum  = TbCardNum.Text.ToString();
            //尝试将证件号码转为int类型
            int CardNum = 0;
            if (int.TryParse(peopleCardNum, out CardNum) == false)
            {
                MessageBox.Show("请输入正确的身份证号码");
                return;
            }
            string peopleBirthDay = TbBirthDay.Text.ToString();
            //尝试将出生年月转为int类型
            int BirthDay = 0;
            if (int.TryParse(peopleBirthDay, out BirthDay) == false)
            {
                MessageBox.Show("请输入正确的出生年月");
                return;
            }

            PeopleModel people = new PeopleModel();
            people.PeopleName = peopleName;
            people.PeopleSex = peopleSex;
            people.PeopleCardNum = CardNum;
            people.PeopleBirthDay = BirthDay;

            

            //调用接口的实例
            IUseSql usersqlIns = new UseSql();           
            bool insresult = usersqlIns.InsetPeople(people);

            if (insresult == true)
            {
                MessageBox.Show("添加成功");
            }
            if (insresult == false)
            {
                MessageBox.Show("添加失败");
            }

        }
        private void ShowListInDatagridView(PeopleModel people)
        {
            //添加一行获得添加的行号
            int index = dataGridView1.Rows.Add();

            //给对应的行的每一列加数据
            dataGridView1.Rows[index].Cells[0].Value = people.PeopleName;
            dataGridView1.Rows[index].Cells[1].Value = people.PeopleSex;
            dataGridView1.Rows[index].Cells[2].Value = people.PeopleCardNum;
            dataGridView1.Rows[index].Cells[3].Value = people.PeopleBirthDay;
        }

        private void BtSelect_Click(object sender, EventArgs e)
        {
            PeopleModel people = new PeopleModel();
            //调用接口的实例
            IUseSql usersql2 = new UseSql();
            IList<PeopleModel> _listresult = usersql2.SelectPeople();
            dataGridView1.Rows.Clear(); //清空datagridview数据
            for (int i = 0; i < _listresult.Count; i++)
            {
                ShowListInDatagridView(_listresult[i]);
            }
            



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            string peopleName = TbName.Text.ToString();
            string peopleSex = TbSex.Text.ToString();
            string peopleCardNum = TbCardNum.Text.ToString();
            string peopleBirthNum = TbBirthDay.Text.ToString();

            PeopleModel people = new PeopleModel();
            people.PeopleName = peopleName;
            people.PeopleSex = peopleSex;
            people.PeopleCardNum = Convert.ToInt32(peopleCardNum);
            people.PeopleBirthDay = Convert.ToInt32(peopleBirthNum);

            //调用接口的实例
            IUseSql usersqldel = new UseSql();
            bool delResult = usersqldel.InsetPeople(people);
            if (delResult == true)
            {
                MessageBox.Show("删除成功");
            }
            if (delResult == false)
            {
                MessageBox.Show("删除失败");
            }

        }
    }
}
