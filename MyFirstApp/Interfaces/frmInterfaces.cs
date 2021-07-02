using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp.Interfaces
{
    public partial class frmInterfaces : Form
    {
        public frmInterfaces()
        {
            InitializeComponent();
        }

        private void FrmInterfaces_Load(object sender, EventArgs e)
        {
            //Interface polymorphism
            IVehiculo vehiculo = new Avion();

            //aquí no podríamos acceder al método clone. Solo podemos extraer las interfaces que implementa a a avión
            vehiculo.Frenar();

            ICloneable clonable = new Avion();
            clonable.
        }
    }
}
