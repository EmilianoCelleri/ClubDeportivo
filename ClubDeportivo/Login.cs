using ClubDeportivo.Clases;
using System.Data;

namespace ClubDeportivo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Llamada del boton ingresar crea tabla y busca en el procedimiento almacenado
            DataTable tablaLogin = new DataTable();
            Datos.Usuarios dato = new Datos.Usuarios();


            // Toma los parametros de los TXT BOX
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);

            // Si el procedimiento devuelve mas de 0 filas y es igual el usuario y la contraseña 

            if (tablaLogin.Rows.Count > 0)
            {
                // Te deja loguear
                
                MessageBox.Show("Ingreso Exitoso");
                frmPrincipal Principal = new frmPrincipal();
                
                // Guarda los datos de usuario y rol en la clase static UsuarioActual
                UsuarioActual.Rol = Convert.ToString(tablaLogin.Rows[0][0]);
                UsuarioActual.Usuario = Convert.ToString(txtUsuario.Text);
                
                // Muestra el form principal y oculta el form login
                Principal.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Usuario o password incorrectos");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}