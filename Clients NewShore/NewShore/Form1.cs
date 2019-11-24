using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace NewShore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        string cadena, car, car1, cadena1 = "";

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            StreamReader ReadClients = new StreamReader(@"C:\Users\Alejandra\Desktop\REGISTRADOS.txt");
            string Line;
            try
            {
                Line = ReadClients.ReadLine();
                while (Line != null)
                {
                    RtbClients.AppendText(Line + "\n");
                    Line = ReadClients.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnLetters_Click(object sender, EventArgs e)
        {
            StreamReader ReadLetters = new StreamReader(@"C:\Users\Alejandra\Desktop\CONTENIDO.txt");
            string Line;
            try
            {
                Line = ReadLetters.ReadLine();
                while (Line != null)
                {
                    RtbLetters.AppendText(Line + "\n");
                    Line = ReadLetters.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnResults_Click(object sender, EventArgs e)
        {

            // StreamWriter escribir = new StreamWriter(@"C:\Users\Alejandra\Desktop\RESULTADOS.txt",true);  //el true es para no reescribir 

            cadena = RtbClients.Text.Trim();
            cadena1 = RtbLetters.Text;


            for (int x = 0; x < cadena.Length; x++)
            {
                car = cadena.Substring(x, 1);
                {
                    txtresultados.Text = cadena;
                }
                for (int y = 0; y < cadena1.Length; y++)
                {
                    car1 = cadena1.Substring(y, 1);
                }
                txtresultados1.Text = cadena1;
            }
        }
    }
}