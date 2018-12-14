using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammaUtente
{
    public class Sicurezza
    {
        char[] alfabeto;

        public Sicurezza()
        {
            caricaAlfabeto();
        }

        void caricaAlfabeto()
        {
            alfabeto = new char[64];
            char lettera = Convert.ToChar(39);
            for (int i = alfabeto.Length - 1; i >= 0; i--, lettera++)
            {
                alfabeto[i] = lettera;
                if (Convert.ToInt32(lettera) == 39)
                    lettera = Convert.ToChar(47);
                else if (lettera == '9')
                    lettera = Convert.ToChar(64);
                else if (lettera == 'Z')
                    lettera = Convert.ToChar(96);
            }
            alfabeto[63] = ' ';
        }
        /// <summary>
        /// Cripta la frase
        /// </summary>
        /// <param name="frase"></param>
        /// <returns></returns>
        public string cripta(string frase)
        {
            string criptato = "";
            for (int i = 0; i < frase.Length; i++)
                for (int y = 0; y < alfabeto.Length; y++)
                    if (frase[i] == alfabeto[y])
                        criptato += Convert.ToChar((Convert.ToInt32(alfabeto[y]) + (i / 2)) - (10 - alfabeto.Length / (i + 1)));
            return criptato;
        }
        /// <summary>
        /// Decripta la frase
        /// </summary>
        /// <param name="frase"></param>
        /// <returns></returns>
        public string decripta(string frase)
        {
            string deciptato = "";
            for (int i = 0; i < frase.Length; i++)
                deciptato += Convert.ToChar(Convert.ToInt32(frase[i]) - (i / 2) + (10 - alfabeto.Length / (i + 1)));
            return deciptato;
        }

        public bool controllaParola(string frase)
        {
            int cont = 0;
            for (int i = 0; i < frase.Length; i++)
                for (int y = 0; y < alfabeto.Length; y++)
                    if (alfabeto[y] == frase[i])
                        cont++;
            if (cont == frase.Length && frase.Length > 0)
                return true;
            return false;
        }
    }
}
