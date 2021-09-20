﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ahorcado_Lizbeth
{
    public partial class Form1 : Form
    {
        int ContadorErrores = 0;
        string Guardacion;
        //string PalabraClave = "ORURO", Palabra = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ////Para obligar a que sólo se introduzcan números
            //if (Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //  if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    //el resto de teclas pulsadas se desactivan
            //    e.Handled = true;
            //}
            

        }
        private void txtLetras_KeyUp(object sender, KeyEventArgs e)
        {
            string letra = Convert.ToString(e.KeyData);

            MessageBox.Show("presionaste: " + letra);

            CompararLetra(letra);
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            string letra = Convert.ToString(e.KeyData);

            MessageBox.Show("presionaste: "+letra);

            CompararLetra(letra);
            
        }

        private void CompararLetra(string pLetra)
        {
            string PalabraClave = "GABRIELA";
            string Palabra = "";
            bool x = PalabraClave.Contains(pLetra);
            string[] resultado = new string[PalabraClave.Length];
            string barritas = "";
            string nuevaPalabra="";
            
            for (int i = 0; i < PalabraClave.Length; i++)
            {
                barritas = barritas + "_";

            }
            label1.Text = barritas;
            //MessageBox.Show("stop");
            if (x==true)
            {
                
                for (int i = 0; i < PalabraClave.Length; i++)
                {
                    int locacion = (PalabraClave.IndexOf(pLetra, i));
                    //MessageBox.Show(Convert.ToString(locacion));

                    //if (locacion==null)
                    //{
                    //    resultado[i] = "_";
                    //}
                    //else
                    //{
                    //    resultado[i] = pLetra;
                    //}

                    if (i == locacion) 
                        Palabra = Palabra + pLetra;
                   
                    else
                        Palabra = Palabra + "_";
                    //resultado[locacion] = pLetra;
                }

                //MessageBox.Show(Palabra);
                label1.Text = Palabra;
                if (Guardacion!=null)
                {
                    //comparar guardacion y Palabra
                    //Palabra->    _R_R_
                    //Guardacion-> O___O

                    char[] Palabra1 = Palabra.ToCharArray();
                    char[] Guardacion1 = Guardacion.ToCharArray();
                    //string[] Palabra1 = new string[] { Palabra };
                    //string[] Guardacion1 = new string[] { Guardacion };


                    for (int i = 0; i < Palabra.Length; i++)
                    {
                        //MessageBox.Show("valor de la i:"+Convert.ToString(i));
                        //for (int i = 0; i < length; i++)
                        //{

                        //}
                        if (Convert.ToString(Guardacion1[i])=="_")
                        {
                            //MessageBox.Show("valor del vector Guardacion1:" + Convert.ToString(Guardacion1[i]));
                            //MessageBox.Show("valor del vector Palabra1:" + Convert.ToString(Palabra1[i]));
                            Guardacion1[i] = Palabra1[i];
                        }
                        
                    }
                    nuevaPalabra = String.Concat(Guardacion1);
                   Guardacion = nuevaPalabra;
                    //MessageBox.Show("nueva:" + nuevaPalabra);
                    label1.Text = nuevaPalabra;
                }
                else
                {
                    Guardacion = Palabra;
                }

                
            }
            else
            {
                //CompararLetra(Palabra);
                MessageBox.Show("No encontrado");
                label1.Text = Guardacion;
                ContadorErrores = ContadorErrores + 1;
                MessageBox.Show(Convert.ToString(ContadorErrores));
                switch (ContadorErrores)
                {
                    case 1:
                        pPalo1.Visible=true;
                        break;
                    case 2:
                        pPalo2.Visible = true;
                        break;
                    case 3:
                        pCabeza.Visible = true;
                        break;
                    case 4:
                        pBrazos.Visible = true;
                        break;
                    case 5:
                        pEstomago.Visible = true;
                        break;
                    case 6:
                        pPiernas.Visible = true;
                        break;
                    default:
                        break;
                }
            }
            
            //for (int i = 0; i < resultado.Length; i++)
            //{
                
                
            //}
            

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            
        }



        private void reiniciar()
        {
            pPalo1.Visible = false;
            pPalo2.Visible = false;
            pCabeza.Visible = false;
            pBrazos.Visible = false;
            pEstomago.Visible = false;
            pPiernas.Visible = false;
        }
    }
}
