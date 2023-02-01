using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Importamos la libreria
using System.Data.SQLite;

namespace SistemaVentas
{
    public partial class frmConexionSQLite : Form
    {
        // Conexion a la base de datos
        public SQLiteConnection cn = new SQLiteConnection("data source=C:/sqlite/BD SQLite/DBSistemaVentas.db");
        public frmConexionSQLite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Agregamos la consulta
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from PROVEEDOR", cn);

            // Creamos un dataTable para contener los datos
            DataTable dt = new DataTable();

            // Llenamos el dataTable
            da.Fill(dt);

            // Agregamos el origen de datos al datagridview
            this.dataGridView1.DataSource = dt;

        }
    }
}
