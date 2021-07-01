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

namespace MyFirstApp.ForeachLoop
{
    public partial class frmForEach : Form
    {
        public frmForEach()
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

            var studentList = new ArrayList();
            //Boxing
            studentList.Add(student);

            foreach (var _student in studentList)
            {   //Unboxing
                MessageBox.Show(((Student)_student).Name +
                    " " + ((Student)_student).Surname);
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
