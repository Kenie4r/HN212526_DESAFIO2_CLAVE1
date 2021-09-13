using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HN212526_DESAFIO2_CLAVE1
{
    class cuenta_bancaria
    {
        //nueva clase de C# en la que vamos a crear nuestro cuenta bancaría

        private string cuentaID = "", userDUI;
        public float interes = 0.12F;

        //vamos a generar el  saldo actual para hacerlo más comodo
    

        public float saldo ;



        /*public float obtenerSaldo()
        {
            Random myrandom = new Random();
            decimal newsaldo = Convert.ToDecimal(myrandom.Next(60, 200));
            string mynewsaldo = Convert.ToString(newsaldo);
            saldo = float.Parse(mynewsaldo);
            return saldo;
        }*/

        //creacion de dui al ingresar
        public string createUserID
        {
            get
            {
                return userDUI;
            }
            set
            {
                userDUI = value;
            }
        }

        //Datos de cuenta bancaria
        public string getMyIDAccount
        {
            get
            {
                if (cuentaID == "")
                {
                    return "ERROR";
                }
                else
                {
                    return cuentaID;
                }
            }
        }
        //generar código de la cuenta
        public string createAccount()
        {
            //una función en la cual vamos a crear la cuenta 
            Random rdn = new Random();
            string codigo = "";
            DateTime dt = new DateTime();
            codigo += dt.ToString("dd");
            codigo += dt.ToString("MM");
            codigo += dt.ToString("yyyy");
            codigo += "-";
            codigo += Convert.ToString(rdn.Next(1000001, 9999999));
            this.cuentaID= codigo;
            return cuentaID;
        }

        //actualizar datos de cuenta
        public void actualizarSaldo(float value)
        {
            float interes = this.interes / 365;
            saldo  = value * interes;
        }


        public void  saveMoney(double more)
        {
            string money = Convert.ToString(more);
            saldo += float.Parse(money);
        }
        public void earnMoney(double minus)
        {
            string money = Convert.ToString(minus);
            saldo -= float.Parse(money);
        }


        //crear interes
        public void setInteres()
        {
            if(saldo == 0)
            {
                interes = 0;
            }
            else if(saldo < 20)
            {
                interes = 5;
            }
            else if(saldo<100)
            {
                interes = 10;
            }else if(saldo <= 500)
            {
                interes = 15;
            }
        }
    }
}
