using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectBD
{
    class Validare
    {
        public bool ValidareNume(string nume)
        {
            Regex verifica = new Regex(@"^([a-z][a-z-A-z]+)$");
            bool valid = false;
            valid = verifica.IsMatch(nume);

            if (nume.Length < 3)
            {
                MessageBox.Show("Numele introdus nu este corect");
                return valid;
            }
            else
            {
                if (valid == true)
                {

                    return valid;
                }
            }
            return valid;
        }
        public bool validareCantitate(string cantitate)
        {
            Regex verifica = new Regex(@"([\\+|0]{1}[1-9]{1}[0-9]+)");
            bool valid = false;
            valid = verifica.IsMatch(cantitate);

            if (cantitate.Length !=0 )
            {
                MessageBox.Show("Doar cifre");
                return valid;
            }
            else
            {
                if (valid == true)
                {

                    return valid;
                }
            }
            return valid;
        }
    }
}
