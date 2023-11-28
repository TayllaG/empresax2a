using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPRESA_X2A.Uteis
{
    public class Validacoes
    {
        public static bool ValidaCPF(string cpf)
        {
            cpf = cpf.Replace(".", "");
            cpf = cpf.Replace("-", "");

            if (cpf.Length != 11)
            {return false;}
            else
            {
                int n1 = Convert.ToInt32(cpf[0].ToString());
                int n2 = Convert.ToInt32(cpf[1].ToString());
                int n3 = Convert.ToInt32(cpf[2].ToString());
                int n4 = Convert.ToInt32(cpf[3].ToString());
                int n5 = Convert.ToInt32(cpf[4].ToString());
                int n6 = Convert.ToInt32(cpf[5].ToString());
                int n7 = Convert.ToInt32(cpf[6].ToString());
                int n8 = Convert.ToInt32(cpf[7].ToString());
                int n9 = Convert.ToInt32(cpf[8].ToString());
                int n10 = Convert.ToInt32(cpf[9].ToString());
                int n11 = Convert.ToInt32(cpf[10].ToString());

                int verificar = (n1 * 10) + (n2 * 9) + (n3 * 8) + (n4 * 7) + (n5 * 6) + (n6 * 5) + (n7 * 4) + (n8 * 3) + (n9 * 2);
                int resultadoDivi = verificar % 11;
                int verificar2 = (n1 * 11) + (n2 * 10) + (n3 * 9) + (n4 * 8) + (n5 * 7) + (n6 * 6) + (n7 * 5) + (n8 * 4) + (n9 * 3) + (n10 * 2);
                int resultadoDivi2 = verificar2 % 11;
                if (resultadoDivi < 2)
                {
                    if (n10 == 0)
                    {
                        int calculo2 = 11 - resultadoDivi2;
                        if (resultadoDivi2 < 2)
                        {
                            if (n11 == 0)
                            {return true;}
                            else
                            {return false;}
                        }
                        else if (resultadoDivi2 >= 2)
                        {

                            if (calculo2 == n11)
                            {return true;}
                            else
                            {return false;}

                        }
                        else {return false;}
                    }
                    else
                    {return false;}
                }
                else if (resultadoDivi >= 2)
                {
                    int calculo = 11 - resultadoDivi;
                    if (calculo == n10)
                    {

                        if (resultadoDivi2 < 2)
                        {
                            if (n11 == 0)
                            {return true;}
                            else
                            {return false;}

                        }
                        else if (resultadoDivi2 >= 2)
                        {
                            int calculo2 = 11 - resultadoDivi2;
                            if (calculo2 == n11)
                            {return true;}
                            else
                            {return false;}

                        }
                        else {return false;}
                    }
                    else {return false;}

                }
                else
                {return false;}

            }

        }
        public static bool ValidarEmail(string email)
        {
            try
            {
                var enderecoEmail = new System.Net.Mail.MailAddress(email);
                if (enderecoEmail.Address == email)
                {return true;}

                else
                {return false;}

            }
            catch
            {return false;}
        }
    }
}
