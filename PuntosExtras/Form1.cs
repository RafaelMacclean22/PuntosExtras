﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntosExtras
{
    public partial class Form1 : Form
    {
        List<Empleados> ListaO = new List<Empleados>();
        Empleados empleados;
        public Form1()
        {
            InitializeComponent();
        }
        public void GuardarPersona()
        {
            empleados = new Empleados(textNombre.Text, comboGenero.Text, int.Parse(textedad.Text), int.Parse(texthoras.Text), int.Parse(textSalario.Text), comboBox1.Text);
            ListaO.Add(empleados);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaO;



        }
        public void getEmpleado()
        {
            IEnumerable<Empleados> nomEmp = from nEmp in ListaO select nEmp;

            foreach (Empleados em in nomEmp)
            {
                textConsulta.AppendText(em.getDatosEmpleado());
            }
        }
        public void getPuesto()
        {
            IEnumerable<Empleados> nomEmp = from nEmp in ListaO select nEmp;

            foreach (Empleados em in nomEmp)
            {
                textConsulta.AppendText(em.getDatospuesto());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas Seguro?", "Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuardarPersona();
            progressBar1.Value = 40;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaO = new List<Empleados>();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textConsulta.Clear();
            getEmpleado();
            progressBar1.Value = 50; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            treeView1.Nodes.Add(comboBox1.Text);
            comboBox1.Text = " ";
            
            progressBar1.Value = 45;

        }

        private void textConsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            textConsulta.Clear();
            progressBar1.Value = 47;
            getPuesto();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
          
        }
    }
    
}
