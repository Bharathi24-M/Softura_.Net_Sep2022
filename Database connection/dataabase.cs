using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Training1
{
    internal class dataabase
    {
        public void getData()
        {
            SqlConnection con = new SqlConnection("Data source=DESKTOP-LHUHC4U\\SQLEXPRESS;database=AdventureWorks2019;user id=sa;password=p@ssword");
            con.Open();
            SqlCommand cmd = new SqlCommand("select DepartmentID,Name,GroupName,ModifiedDate from HumanResources.Department", con);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + "\t" + reader[1].ToString() + "\t" + reader[2].ToString() + "\t" + reader[3].ToString());
            }
        }
        public void insData(string Name, string GroupName, DateTime ModifiedDate)
        {
            SqlConnection con = new SqlConnection("Data source=DESKTOP-LHUHC4U\\SQLEXPRESS;database=AdventureWorks2019;user id=sa;password=p@ssword");
            SqlCommand cmd = new SqlCommand("sp_depart", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = Name;
            cmd.Parameters.AddWithValue("@GroupName", SqlDbType.NVarChar).Value = GroupName;
            cmd.Parameters.AddWithValue("@ModifiedDate", SqlDbType.NVarChar).Value = ModifiedDate;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Inserted");
        }

        public static void Main()
        {
            dataabase dobj1 = new dataabase();
            dobj1.getData();
            dobj1.insData("Sales research", "Research and Development",DateTime.Now);

        }
    }
}
