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

        string[] Nombre = new string[Tam];
        int[] Telefono = new int[Tam];
        public void IntroducirNombre(string[] nombre, int[] telefono)
        {
            string aux = "";

            if (VerificarVectorLleno(Nombre))
            {

                for (int i = 0; i < nombre.Length; i++)
                {
                    aux = Interaction.InputBox("Introduce el nombre del contacto");
                    if (!VerificarContacto(aux, nombre))
                    {
                        Nombre[i] = aux;
                        telefono[i] = int.Parse(Interaction.InputBox("Introduce el número de telefono del contacto"));

                    }
                    else
                    {
                        MessageBox.Show("El contacto ya existe");
                        i--;
                    }
                }


            }
            else
            {
                MessageBox.Show("No se pueden añadir más contactos ya que la ageda está llena");
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
        }

        bool VerificarVectorLleno(string[] nombre)
        {
            bool verificar = false;
            for (int i = 0; i < nombre.Length && !verificar; i++)
            {
                if (nombre[i] == null)
                {
                    verificar = true;
                }

            }
            return verificar;
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            IntroducirNombre(Nombre, Telefono); /* Adrian Carbonell*/
        }
    }
}
