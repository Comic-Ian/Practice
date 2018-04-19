using Demo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.Contorllers
{
    //写一个抽象的接口
    public interface IUseSql
    {
        void InsetPeople(PeopleModel people);

        void UpdatePeople(PeopleModel people);

        void SelectPeople(PeopleModel people);

        void DeletePeople(PeopleModel people);
    }

    //将抽象的接口实例化
    public class UseSql : IUseSql
    {
        //连接字符串
        private static string connectStr = "server = localhost; user id = root; password = root123; database = test";
        public void DeletePeople(PeopleModel people)
        {
            throw new NotImplementedException();
        }

        public void InsetPeople(PeopleModel people)
        {
            //bool Add()
            //{ 
             
                //1.连接数据库
                //使用MySqlConnection这个对象进行实例化一个连接对象，他需要一个连接字符串的参数
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connectStr);
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    //然后打开它
                    conn.Open();
                }

                //2.对数据库进行操作
                //需要MySqlCommand 对象，进行实例化一个操作对象，需要的参数有两个：1.sql语句 2.连接对象

                //sql语句 对表tablegun插入一条数据
                string Na = people.PeopleName;
                string Se = people.PeopleSex;
                int Cn = people.PeopleCardNum;
                int Bd = people.PeopleBirthDay;
                string sql =string.Format( "insert into tbl_people(Name,Sex,CardNum,BirthDay) values({0},{1},{2},{3})",Na,Se,Cn,Bd);
                //实例化执行对象
                MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(sql,conn);
                //执行一条sql语句 返回执行成功的结果条数 insert into
                int result = command.ExecuteNonQuery();

                //3.执行完毕 需要释放执行对象并且关闭数据库连接
                command.Dispose();
                conn.Close();

            //    if (result > 0)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}


        }

        public void SelectPeople(PeopleModel people)
        {
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connectStr);

            if (conn.State != System.Data.ConnectionState.Open)
            {
                //然后打开它
                conn.Open();
            }
            string sql = ("select * from tbl_people");

            //实例化执行对象
            MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
            //执行一条sql语句 返回执行成功的结果条数 insert into
            //int result = command.ExecuteNonQuery();
            MySql.Data.MySqlClient.MySqlDataReader reader = command.ExecuteReader();
            //首先判断这个结果集是否有行，有行则证明有数据
          
                //开始遍历这个程序及 他是表格的形式，理解遍历，他就是一行一行的读数据

                //这里使用了一个read()方法，他意思是读取一行数据。如果有一行数据会返回true,如果没有则返货false，读一行则少一行
                while (reader.Read())
                {
                    //while循环去读取
                    //这个时候我开始读一行数据 一行数据对应的是一个对象
                    //然后这样取出来他是一个object 的对象
                    //object 类型  是一个基类
                    //所有的类型 最基本 的类型就是object  这些类型都是从object 衍生来的
                    //所以我们需要转换成对应的类型，比如这个ID 我们要int类型
                    //name要string类型
                    PeopleModel peoples = new PeopleModel();
                    peoples.PeopleCardNum = Convert.ToInt32(reader["CardNum"]);
                    peoples.PeopleBirthDay = Convert.ToInt32(reader["BirthDay"]);
                    peoples.PeopleName = reader["Name"].ToString();
                    peoples.PeopleSex = reader["Sex"].ToString();
                }
            

            //3.执行完毕 需要释放执行对象并且关闭数据库连接
            command.Dispose();
            conn.Close();


        }

        public void UpdatePeople(PeopleModel people)
        {
            throw new NotImplementedException();
        }
    }
}
