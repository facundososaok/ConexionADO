namespace prySosaConexionDB
{
    public partial class Form1 : Form
    {
        private clsConexionDB conexion;

        public Form1()
        {
            InitializeComponent();
            conexion = new clsConexionDB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexion.abrirConexion();
            conexion.mostrarNombreProductos();
        }
    }
}
