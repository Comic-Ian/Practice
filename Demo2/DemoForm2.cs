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
            IUseSql usersql1 = new UseSql();
            usersql1.InsetPeople(people);

        }

        private void BtSelect_Click(object sender, EventArgs e)
        {
            PeopleModel people = new PeopleModel();
            //调用接口的实例
            IUseSql usersql2 = new UseSql();
            usersql2.SelectPeople(people);

            int type;
            DataTable dt = new DataTable("subject");
            dt.Columns.Add("人员信息/序号", typeof(string));
            dt.Columns.Add("姓名", typeof(string));
            dt.Columns.Add("性别", typeof(string));
            dt.Columns.Add("证件号码", typeof(string));
            dt.Columns.Add("出生年月", typeof(string));
            for (int i = 0; i < 4; i++)  //用循环添加4个行集~
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(dr);
            }
            dt.Rows[0][0] = "(1)";
            dt.Rows[1][0] = "(2)";
            dt.Rows[2][0] = "(3)";
            dt.Rows[3][0] = "(4)";
           

            //查询出来的东西在dataGridView1里面显示
            //int index = this.dataGridView1.Rows.Add();
            //this.dataGridView1.Rows[index].Cells[0].Value = people.PeopleName;
            //this.dataGridView1.Rows[index].Cells[0].Value = people.PeopleSex;
            //this.dataGridView1.Rows[index].Cells[0].Value = people.PeopleCardNum;
            //this.dataGridView1.Rows[index].Cells[0].Value = people.PeopleBirthDay;
            dt.Rows[1][1] = people.PeopleName;
            dt.Rows[1][2] = people.PeopleSex;
            dt.Rows[1][3] = people.PeopleCardNum;
            dt.Rows[1][4] = people.PeopleBirthDay;
            this.dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }
    }
}
