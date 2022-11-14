using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viajes
{
    public partial class frmViaje : Form
    {
        AccesoDatos oBD;
        public frmViaje()
        {
            oBD = new AccesoDatos();
            InitializeComponent();
        }

        private void frmViaje_Load(object sender, EventArgs e)
        {
            cargarCombo();
        }

        private void cargarCombo()
        {
            //DataTable tabla = new DataTable();
            DataTable tabla = oBD.consultarBD("SELECT * FROM Transportes ");
            cboTransporte.DataSource = tabla;
            //cboTransporte.DisplayMember = "nombreTransporte";
            //cboTransporte.ValueMember = "idTransporte";
            cboTransporte.DisplayMember = tabla.Columns[1].ColumnName;
            cboTransporte.ValueMember = tabla.Columns[0].ColumnName;
            cboTransporte.DropDownStyle = ComboBoxStyle.DropDownList;
        }


    }
}
