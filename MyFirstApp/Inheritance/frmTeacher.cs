using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp.Inheritance
{
    public partial class frmTeacher : Form
    {
        public frmTeacher()
        {
            InitializeComponent();
        }

        private void FrmTeacher_Load(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.Name = "Ferran";
            teacher.Surname = "Cabestany";
            teacher.Subject = "Physics";
            teacher.Salary = 40000.00f;

            //Polymorphism example
            Person person1 = new Teacher();
            //como las matryoskas, la izquierda la grande y la derecha la clase más pequeña

            person1.Name = "Cèsar";
            person1.Surname = "Ferrater";
            //Unboxing para sacar salario y subject
            ((Teacher)person1).Salary = 50000.00f;
            ((Teacher)person1).Subject = "Materials Physics";

            MessageBox.Show("The " + ((Teacher)person1).Subject + " teacher's name is " + person1.Name + " " + person1.Surname +
                " and his salary is " + ((Teacher)person1).Salary + " €.");
        }
    }
}
