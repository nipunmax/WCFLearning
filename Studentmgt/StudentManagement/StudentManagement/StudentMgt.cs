using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace StudentManagement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class StudentMgt : IStudentMgt
    {

        public void DeleteStudent(int id)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("DeleteStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter para1 = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = id
                };
                cmd.Parameters.Add(para1);
                conn.Open();
                cmd.ExecuteNonQuery();

            }
        }

        public Student getStudent(int id)
        {
            Student std = new Student();

            String cn = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(cn))
            {
                SqlCommand cmd = new SqlCommand("searchStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter para1 = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = id
                };

                cmd.Parameters.Add(para1);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {


                    std.id = Convert.ToInt32(reader["Id"]);
                    std.name = Convert.ToString(reader["Name"]);
                    std.address = Convert.ToString(reader["SAddress"]);
                    std.age = Convert.ToInt32(reader["Age"]);
                    std.education = Convert.ToString(reader["Education"]);
                    std.gender = Convert.ToString(reader["Gender"]);
                    std.mobile = Convert.ToInt32(reader["mobile"]);
                    std.email = Convert.ToString(reader["email"]);
                    std.contact = Convert.ToString(reader["contact"]);
                   
                }
            }
            return std;
            
        }

        public void setStudent(Student std)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("AddStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter para1 = new SqlParameter
                {
                    ParameterName = "@id",
                    Value  = std.id
                };
                cmd.Parameters.Add(para1);
                SqlParameter para2 = new SqlParameter
                {
                    ParameterName = "@name",
                    Value = std.name
                };
                cmd.Parameters.Add(para2);
                SqlParameter para3 = new SqlParameter
                {
                    ParameterName = "@age",
                    Value = std.age
                };
                cmd.Parameters.Add(para3);
                SqlParameter para6 = new SqlParameter
                {
                    ParameterName = "@gender",
                    Value = std.name
                };
                cmd.Parameters.Add(para6);
                SqlParameter para4 = new SqlParameter
                {
                    ParameterName = "@SAddress",
                    Value = std.address
                };
                cmd.Parameters.Add(para4);
                SqlParameter para5 = new SqlParameter
                {
                    ParameterName = "@education",
                    Value = std.education
                };
                cmd.Parameters.Add(para5);
                SqlParameter para7 = new SqlParameter
                {
                    ParameterName = "@mobile",
                    Value = std.mobile
                };
                cmd.Parameters.Add(para7);
                SqlParameter para8 = new SqlParameter
                {
                    ParameterName = "@email",
                    Value = std.email
                };
                cmd.Parameters.Add(para8);
                SqlParameter para9 = new SqlParameter
                {
                    ParameterName = "@contact",
                    Value = std.contact
                };
                cmd.Parameters.Add(para9);
              
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
