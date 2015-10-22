using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace StudentRegForm
{
    public partial class RegForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            StudentRef.StudentMgtClient client = new StudentRef.StudentMgtClient();
            StudentRef.Student student = new StudentRef.Student();
            student.id = Convert.ToInt32(TextBox1.Text);
            student.name = TextBox2.Text;
            student.address = TextBox3.Text;
            student.age = Convert.ToInt32(TextBox4.Text);
            student.gender = malefemale();
            student.education = TextBox5.Text;
            student.mobile = Convert.ToInt32(TextBox7.Text);
            student.email = TextBox8.Text;
            student.contact = contacted();
            
            client.setStudent(student);
        }

        
        private string malefemale()
        {
           
            if (Male.Checked)
            {
                return "male";
            }
            return "female";
        }
        private string contacted()
        {
            if (Mobile.Checked && Email.Checked)
                return "mobileEmail";
            else if (Mobile.Checked)
                return "mobile";
            else
                return "email";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
            //string number = "<script language=\"javascript\"> prompt('Enter the ID of student');</script>";
            int number = Convert.ToInt32(TextBox1.Text);
            
          
                StudentRef.StudentMgtClient client = new StudentRef.StudentMgtClient();
                StudentRef.Student stdnt = client.getStudent(number);
                TextBox1.Text = Convert.ToString(stdnt.id);
                TextBox2.Text = stdnt.name;
                TextBox3.Text = stdnt.address;
                TextBox4.Text = Convert.ToString(stdnt.age);
        

        }
        private void MsgBox(string sMessage)
        {
            string msg = "<script language=\"javascript\">";
            msg += "alert('" + sMessage + "');";
            msg += "</script>";
            Response.Write(msg);
        }

        protected void Male_CheckedChanged(object sender, EventArgs e)
        {
            Female.Checked = false;
        }

        protected void Female_CheckedChanged(object sender, EventArgs e)
        {
            Male.Checked = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            Male.Checked = false;
            Female.Checked = false;
            Email.Checked = false;
            Mobile.Checked = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox1.Text);
            StudentRef.StudentMgtClient client = new StudentRef.StudentMgtClient();
            client.DeleteStudent(id);
        }
    }
}