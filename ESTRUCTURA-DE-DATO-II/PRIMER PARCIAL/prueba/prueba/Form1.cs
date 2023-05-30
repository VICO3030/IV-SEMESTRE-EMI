using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class Form1 : Form
    {
        //creamos  la variable global
        string genero;
        //globale mejor y peor alumno
        float mayor_nota, menor_nota;
        public Form1()//constructor 
        {
            InitializeComponent();
            genero = "";//inicializamos la variable
            //incializamos la mayor y menor
            menor_nota = 10;
            mayor_nota = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rdb_hom_CheckedChanged(object sender, EventArgs e)
        {
            genero = "FEMENINO";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LST_alumnos.Items.Add("---------------------------------------------");
            //programacion para guardar a la lista y mostrar
            LST_alumnos.Items.Add(txt_cod.Text + "  - " + txt_nom.Text );
            //permite adicionar lineas
            LST_alumnos.Items.Add("GENERO : " + genero);
            LST_alumnos.Items.Add("EDAD : " + txt_edad.Text);//propiedad TXT siempre trabajar
            LST_alumnos.Items.Add("CARRERA : " + CBO_CARRERA.Text);
            LST_alumnos.Items.Add("---------------------------------------------");

            
            //sacar mensajes de pantalla
            MessageBox.Show("ALUMNO REGISTRADO !!!");
            //AL registrar se habilitarab el boton 
            Btn_calcularnota.Enabled = true;
            
            

        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            //Borramos codigo ingresado limpiar
            txt_cod.Clear();
            txt_edad.Clear();
            txt_nom.Clear();
            txt_n1.Clear();
            txt_n2.Clear();
            txt_n3.Clear();
            CBO_CARRERA.Text = "";
            Rdb_fem.Checked = false;
            Rdb_mas.Checked = false;
            //desabilito los botones calcularnota y limpiar
            Btn_calcularnota.Enabled = false;
            Btn_Limpiar.Enabled = false;
            
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();//cerramos secion

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rdb_mas_CheckedChanged(object sender, EventArgs e)
        {
            genero = "MASCULINO";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Btn_calcularnota_Click(object sender, EventArgs e)
        {
            float promedio , n1 ,n2,n3;
            Btn_Limpiar.Enabled = true;
            //convierte ese texto a numeros float.Parse
            n1 = float.Parse(txt_n1.Text);
            n2 = float.Parse(txt_n2.Text);
            n3 = float.Parse(txt_n3.Text);
            promedio = (n1 + n2 + n3) / 3;
            if (promedio >= 5.1)
            {
                LST_aprobados.Items.Add("---------------------------- " );
                LST_aprobados.Items.Add(txt_nom.Text);
                LST_aprobados.Items.Add("PROMEDIO : "+ Math.Round(promedio,2));
                LST_aprobados.Items.Add("---------------------------- ");
            }
            else
            {
                LST_reprobados.Items.Add("---------------------------- ");
                LST_reprobados.Items.Add(txt_nom.Text);
                LST_reprobados.Items.Add("PROMEDIO :  "+ Math.Round(promedio, 2));
                LST_reprobados.Items.Add("---------------------------- ");
            }

            //calculamos la mayor nota 
            if (promedio > mayor_nota)
            {
                mayor_nota = promedio;
                
            }
            if (promedio < menor_nota)
            {
                menor_nota = promedio;
            }

        }

        private void Btn_notalta_baja_Click(object sender, EventArgs e)
        {
            MessageBox.Show("la nota mas alta es de  : "+mayor_nota);

            MessageBox.Show("la nota mas alta es de  : " + menor_nota);
        }

        private void LST_aprobados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
