using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HN212526_DESAFIO2_CLAVE1
{
    public partial class logeo : Form
    {
        cuenta_bancaria bankdata = new cuenta_bancaria();
        public logeo()
        {
            InitializeComponent();
        }

           public bool IsNumeric(string value)
        {
            float result;
            return float.TryParse(value, out result);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dui_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
           
            string textbox1 = txtnumeroDUI.Text, textSaldo = txtSaldo.Text;
            if((textbox1.Length>0 && IsNumeric(textbox1)) && (textSaldo.Length > 0 && IsNumeric(textSaldo)))
            {
                float saldo = float.Parse(textSaldo);
                if(textbox1.Length > 8 ||  saldo>500)
                {
                    if (saldo > 500) {
                        MessageBox.Show("Ingrese una cantidad de dinero justa por favor entre 0 a 500$");
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese bien los datos");

                    }
                }
                else
                {
                    
                    //vamos a usar la variable saldo de bankdata 
                    bankdata.saldo = saldo;
                    //obtenemos un id del banco al azar
                    string userbank = bankdata.createAccount();
                    bankdata.createUserID = textbox1;
                    //vamos a generar el interes por el valor de este saldo ingresado
                    bankdata.setInteres();
                    //ahora es momento de generar toda la información en la pantalla
                    btnIngresar.Visible = false;
                    labelsaldo.Text = "Saldo actual";
                    //vamos a hacer visibles los datos
                    txtCuentaID.Text = userbank;
                    txtCuentaID.Visible = true;
                    label5.Visible = true;

                    label4.Visible = true;
                    txtInteres.Text = Convert.ToString(bankdata.interes + "%");
                    txtInteres.Visible = true;
                    btnSacardinero.Visible = true;
                    btnSalir.Visible = true;
                    btnSave.Visible = true;

                    //calncelamos cambiar datos
                    txtnumeroDUI.Enabled = false;
                    txtSaldo.Enabled = false;
                    bankdata.actualizarSaldo(bankdata.interes / 100);
                    lbta.Visible = true;
                    lbTransactions.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese sus datos para poder continuar");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //vamos a usar un referencia a VSBasica para poder usar el input box
            string saldo ;
            bool terminar = false;
            double valor = 0;
            do
            {
                saldo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad a guardar", "Guardar dinero", "0", 100, 0);
                if (IsNumeric(saldo))
                {
                    valor = Convert.ToDouble(saldo);
                    if (valor <= 0)
                    {
                        MessageBox.Show("Por favor ingrese el valor en números positivos y mayor a 0");
                    }
                    else
                    {
                        terminar = true;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese el valor en números");
                }
            } while (terminar == false);
            bankdata.saveMoney(valor);
            MessageBox.Show("Saldo actualizado a " + bankdata.saldo + "$");
            txtSaldo.Text = Convert.ToString(bankdata.saldo);
            bankdata.actualizarSaldo(bankdata.interes / 100);
            lbTransactions.Items.Add("Se ingresaron " +valor+ "$");
            lbTransactions.Items.Add("Saldo actualizado a  " + bankdata.saldo + "$");
        }

        private void btnSacardinero_Click(object sender, EventArgs e)
        {
            string saldo;
            bool terminar = false;
            double valor = 0;
            if(bankdata.saldo == 0)
            {
                MessageBox.Show("No se puede retirar dinero, su cuenta está a 0$");
            }
            else
            {
                do
                {
                    saldo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad a guardar", "Guardar dinero", "0", 100, 0);

                    if (IsNumeric(saldo))
                    {
                        valor = Convert.ToDouble(saldo);
                        if (valor <= 0 || valor > bankdata.saldo)
                        {
                            MessageBox.Show("La cantidad no es posible de obtener, por favor revise su saldo");
                        }
                        else
                        {
                            terminar = true;
                        }

                    }
                    else
                    {

                    }
                } while (terminar == false);
                bankdata.earnMoney(valor);
                MessageBox.Show("Se ha retirado: " + Convert.ToString(valor) + "$ con exito");
                txtSaldo.Text = Convert.ToString(bankdata.saldo);
                bankdata.actualizarSaldo(bankdata.interes / 100);
                lbTransactions.Items.Add("Se retiraton" + valor + "$");
                lbTransactions.Items.Add("Saldo actualizado a  " +bankdata.saldo + "$");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            bankdata.actualizarSaldo(bankdata.interes / 100);
            MessageBox.Show("Sesión cerrada con éxito");
            bankdata.saldo = 0;
            bankdata.createUserID = "";
            //vamos a generar el interes por el valor de este saldo ingresado
            bankdata.setInteres();
            //ahora es momento de generar toda la información en la pantalla
            btnIngresar.Visible = true;
            labelsaldo.Text = "Saldo inicial";
            //vamos a hacer visibles los datos
            txtCuentaID.Text = "";
            txtCuentaID.Visible = false;
            label5.Visible = false;

            label4.Visible = false;
            txtInteres.Text = "";
            txtInteres.Visible = false;
            btnSacardinero.Visible = false;
            btnSalir.Visible = false;
            btnSave.Visible = false;

            //calncelamos cambiar datos
            txtnumeroDUI.Enabled = true;
            txtSaldo.Enabled = true;
            txtnumeroDUI.Text = "";
            txtSaldo.Text = "";
        }
    }
}
