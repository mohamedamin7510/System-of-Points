using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
namespace PointsSystem
{

    public partial class Form1 : Form
    {
        private string Query = $"select p.ID , Fname+ '   '+  Lname [full name] ,Average, Mnth , DENSE_RANK()over(order by Average desc) Rank from Person P inner join Points ps on p.ID = ps.ID where mnth = {DateTime.Now.Month}";
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView_ReadAllUsers.DataSource = DBLayer.Select(Query);

            GetMiniumTasks();

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                DBLayer.Update(int.Parse(addpoint.Text), int.Parse(textBox2_addtasks.Text), int.Parse(textBox1_Id.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView_ReadAllUsers.DataSource = DBLayer.Select(Query);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBLayer.Update(int.Parse(addpoint.Text), int.Parse(textBox2_addtasks.Text), int.Parse(textBox1_Id.Text));
            dataGridView_ReadAllUsers.DataSource = DBLayer.Select(Query);
        }


        private void PersonOrders()
        {


            string query2 =
               $" select t.ID , Fname + ' ' + Lname , totalaverage , DENSE_RANK() over (order by totalaverage desc) orderr from (  select  ID ,sum(Average) totalaverage from Points  where Mnth in({month_textbox.Text})   Group by  ID )  as  t , Person   where t.ID = Person.ID ";



            DataTable dt = DBLayer.Select(query2);


            dataGridView_Ordering.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonOrders();
        }

        private void dataGridView_Maxin_Tasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }




        public void GetMiniumTasks()
        {
            string query =
             $"  select top(3) p.Fname + ' ' + p.Lname [full mame ], ps.NTasks , Mnth from points ps , Person p  where ps.ID = p.ID and  mnth = {DateTime.Now.Month} order by ps.NTasks";

            dataGridView_Maxin_Tasks.DataSource = DBLayer.Select(query);
        }
    }
}
