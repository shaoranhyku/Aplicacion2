using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Clase
{
    public partial class Form1 : Form
    {
        Boolean mayorEdad;
        int edad;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Muestra un mensaje dependiendo de los datos introducidos al hacer click al botón.
        /// </summary>
        /// <param name="sender">Objeto que activa el método.</param>
        /// <param name="e"> Argumentos del evento.</param>
        private void button1_Click_2(object sender, EventArgs e)
        {
            lblResponse.Visible = true;
            edad = (int)nbrAge.Value;
                //Verifica que la edad es mayor que 0 y que no hay cambos en blanco.
                if((edad>0) && String.IsNullOrEmpty(txtName.Text) && String.IsNullOrEmpty(cbxDayOfWeek.Text))
                {

                    mayorEdad = (edad >= 18);
                    //Si es mayor de edad, mostrará un mensaje concreto.
                    if (mayorEdad)
                    {
                        lblResponse.Text = String.Format("{0} es mayor de edad y es {1}.", txtName.Text, cbxDayOfWeek.Text);
                    }
                    //En caso contratio, mostrará otro mensaje.
                    else
                    {
                        Boolean diaLectivo;
                        //Para el mensaje, se comprueba si es sábado o domingo.
                        if (cbxDayOfWeek.Text.Equals("Sábado") || cbxDayOfWeek.Text.Equals("Domingo"))
                        {
                            diaLectivo = false;
                        }
                        else
                        {
                            diaLectivo = true;
                        }

                        lblResponse.Text = String.Format("{0} es menor de edad y es {1}, por lo que {2}", txtName.Text, cbxDayOfWeek.Text, diaLectivo ? "hoy tiene clase." : "hoy no tiene clase.");
                    }
                }
                else
                {
                    lblResponse.Text = "Datos erroneos";
                }


        }

    }
}
