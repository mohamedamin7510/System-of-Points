using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Identity.Client.AuthScheme.PoP;
using PointsSystem;
using System.Net;
namespace PointsSystem
{
    internal class DBLayer
    {
        public static SqlCommand commnd;
        public static SqlConnection conn;



        public static DataTable Select(string TxtCommand)
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SysPoint"].ConnectionString);
            commnd = new SqlCommand(TxtCommand, conn);

            SqlDataAdapter sqladapter = new SqlDataAdapter(commnd);
            DataTable dt = new DataTable();
            try
            {
                sqladapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter the needed months.." );
            }
            return dt;
        }





        /// <summary>
        /// this method for updating the daily points and tasks 
        /// </summary>
        /// <param name="points"></param>
        /// <param name="tasks"></param>
        public static void Update(int points, int tasks, int Id)
        {
            string TextCommand = " update  points set TPoints += @Point , NTasks += @Tasks from Points ps ,Person p " +
                "where p.ID = ps.ID and ps.ID = @Id and ps.Mnth = @month";
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SysPoint"].ConnectionString);
            commnd = new SqlCommand(TextCommand, conn);
            commnd.Parameters.AddWithValue("Point", points);
            commnd.Parameters.AddWithValue("Tasks", tasks);
            commnd.Parameters.AddWithValue("Id", Id);
            commnd.Parameters.AddWithValue("month", DateTime.Now.Month);
            try
            {
                using (conn)
                {
                    conn.Open();
                    int n = commnd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show($"{n} of persons have been updated .");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message 
                    + "may be id is not  entered ... ");

            }


        }







    }
}
