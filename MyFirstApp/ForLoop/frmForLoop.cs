using MyFirstApp.ForeachLoop;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp.ForLoop
{
    public partial class frmForLoop : Form
    {
        public frmForLoop()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StudentId = Convert.ToInt32(txtStudentId.Text);
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Age = Convert.ToInt32(txtAge.Text);

            List<Student> studentList = new List<Student>();
            //Boxing
            studentList.Add(student);

            for (int i = 0; i < studentList.Count; i++)
            {   //Unboxing
                MessageBox.Show(studentList[i].Name +
                    " " + studentList[i].Surname);
            }
        }

        private void TxtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtStudentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
