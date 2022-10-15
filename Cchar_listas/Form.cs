using System.Security.Cryptography.X509Certificates;

namespace Cchar_listas
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save_person();
        }
   
        private void button_eliminar_Click(object sender, EventArgs e)
        {
            delete(txt_nombre.Text);
        }

        List<Articulo> lista = new List<Articulo>();
        List<Articulo> listaB = new List<Articulo>();
        
        public void save_person()
        {
            string _nombre = txt_nombre.Text;
            int _id = lista.Count + 1;

            // Se crea el objeto persona1
            Articulo persona1 = new Articulo(_nombre, _id);

            // Agrega a lista B
            lista.Add(persona1);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
        }


       public void delete(string nombre)
        {
            foreach(var Articulo in lista)
            {
                if (Articulo.Nombre == nombre)
                {   
                    // Agrega a lista B
                    listaB.Add(Articulo);
                    
                    // Actualiza dataGrid
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = listaB;
                    
                    //Remueve de lista A
                    lista.Remove(Articulo);
                    break;

                }
            }

            // Actualiza dataGrid
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
        }
    }
}