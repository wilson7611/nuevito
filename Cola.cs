using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Colac
{
    public class Cola
    {
        public string[] coladatos = new string[100];
        public int primero = 0;
        public int ultimo = -1;
        public int MaxCola = 9;
        public string valor = "";

        public Cola()
        {
            primero = 0;
            ultimo = 0;
        }

        public bool Vacia()
        {
            if (ultimo < primero) return true;
            else return false;
        }

        public bool Llena()
        {
            if (ultimo == MaxCola - 1) return true;
            else return false;
        }

        public void Insertar(string insert)
        {
            if (Llena()) MessageBox.Show("Error: La cola de elementos esta LLENA");
            else
            {
                ultimo++;
                coladatos[ultimo] = insert;

            }
        }

        public string Eliminar()
        {
            string valor = " ";
            if (Vacia()) MessageBox.Show("Error: La cola de elementos esta VACIA");
            else
            {
                valor = coladatos[ultimo];

                ultimo--;
            }
            return valor;
        }
    }
}