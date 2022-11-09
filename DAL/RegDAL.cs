using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Newproj.DAL
{
    public class RegDAL
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public RegDAL()
        {
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection Getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public object userlogin(BAL.RegBAL obj)
        {
          Getcon();
         cmd.CommandType = CommandType.Text;
         cmd.CommandText = "insert into login values('" + obj.studusername + "','" + obj.studpasswd + "','student','Not confirmed');select @@IDENTITY";


            object id =  cmd.ExecuteScalar();
         return id;
            
            
        }

        public int stud_reg(BAL.RegBAL obj)
        {
           

            string s = "insert into Student_Details values('" + obj.studname + "','" + obj.studemail + "','" + obj.studphone + "','" + obj.studgender + "','" + obj.studcourse + "','" + obj.studdob + "','" + obj.id + "')";

            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }

        

        
        public DataTable view_users()
         {
                string qry = "select s.*,l.* from Student_Details s inner join login l on s.lid=l.lid where l.status='not confirmed' and type='student'";
                SqlCommand cmd = new SqlCommand(qry, Getcon());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
                
         }

        public int Confirm_user(BAL.RegBAL obj)
        {
            
            string s = "update login set status='confirmed' where lid=" + obj.studid + "";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public int User_login(BAL.RegBAL obj)
        {
            string s = "select  count(*) from login where username='" + obj.username + "' and password='" + obj.password + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            int row = (int)cmd.ExecuteScalar();
            return row;
        }


        public object faclogin(BAL.RegBAL obj)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login values('" + obj.facusername + "','" + obj.facpasswd + "','faculty','Not confirmed');select @@IDENTITY";
            object facob = cmd.ExecuteScalar();
            return facob;

         }

        public int faculty_reg(BAL.RegBAL obj)
        {

            string s = "insert into Faculty_Details values('" + obj.facname + "','" + obj.facemail + "','" + obj.facphone + "','" + obj.facgender + "','" + obj.faccollege + "','" + obj.facdob + "','" + obj.facob + "')";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }


        public DataTable fac_view_users()
        {
            string qry = "select s.*,l.* from Faculty_Details s inner join login l on s.lid=l.lid where l.status='not confirmed' and type='faculty'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public int Confirm_fac_user(BAL.RegBAL obj)
        {

            string s = "update login set status='confirmed' where lid=" + obj.facid + "";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
    }
}