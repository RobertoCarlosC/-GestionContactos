using System.Runtime.Intrinsics.X86;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestiondeContactos
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int Tam = 4;

        string[] nombre = new string[Tam];
        int[] telefono = new int[Tam];
        public void IntroducirNombre(string[] nombre, int[] telefono)
        {
            string aux;
            for (int i = 0; i < nombre.Length; i++)
            {
                if (VerificarVectorLleno(nombre))
                {

                    if (string.IsNullOrEmpty(nombre[i]))
                    {
                        aux = Interaction.InputBox("Introduce el nombre del contacto");
                        if (!VerificarContacto(aux, nombre))
                        {
                            nombre[i] = aux;
                            telefono[i] = int.Parse(Interaction.InputBox("Introduce el número de teléfono del contacto"));
                            MessageBox.Show("El contacto se ha añadido correctamente");
                        }
                        else
                        {
                            MessageBox.Show("El contacto ya existe");
                            i--;
                        }
                    }
                }
            }
        }

        bool VerificarContacto(string aux, string[] nombre)
        {
            bool verificado = false;

            for (int i = 0; i < nombre.Length && !verificado; i++)
            {
                if (nombre[i] == aux)
                {
                    verificado = true;
                }
            }
            return verificado;
            //AAAAAAAAAAAA
        }

        bool VerificarVectorLleno(string[] nombre)
        {
            for (int i = 0; i < nombre.Length; i++)
            {
                if (string.IsNullOrEmpty(nombre[i]))
                {
                    return true;
                }
            }
            return false;
        }

        void EliminarContacto(string[] nombre, int[] telefono)
        {
            string aux = Interaction.InputBox("Introduce el nombre del contacto que quieres eliminar");

            if (VerificarContacto(aux, nombre))
            {
                for (int i = 0; i < nombre.Length; i++)
                {
                    if (nombre[i] == aux)
                    {
                        nombre[i] = null;
                        telefono[i] = -1;
                        MessageBox.Show("Contacto eliminado correctamente");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("El contacto no existe");
            }
        }

        string MostrarContactos()
        {
            bool hayContactos = false;
            string testeo = "";
            for (int i = 0; i < Tam; i++)
            {
                if (nombre[i] != null)  // Solo muestra contactos existentes
                {
                    testeo +=  "Nombre: " + nombre[i] + "\n" + "Telefono: " + telefono[i] + "\n" ;
                    hayContactos = true;
                }
            }

            if (!hayContactos)
            {
                MessageBox.Show("No hay contactos almacenados.", "Agenda Vacía");
            }

            return testeo;

        }


        private void btnAñadir_Click(object sender, EventArgs e)
        {
            IntroducirNombre(nombre, telefono); /* Adrian Carbonell*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminarContacto_Click(object sender, EventArgs e)
        {
            EliminarContacto(nombre, telefono);
        }

        private void btnMostrarContactos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MostrarContactos());
        }
    }
}
