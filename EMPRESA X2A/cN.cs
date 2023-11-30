using System.Linq;
using System.Text.RegularExpressions;

public static class Cnpj
{
    public static bool Validar(string cnpj)
    {
        if (string.IsNullOrWhiteSpace(cnpj))
        {
            return false;
        }

        cnpj = RemoverCaracteresEspeciais(cnpj);
        if (!ValidarNumerico(cnpj))
        {
            return false;
        }

        cnpj = ZeroEsquerda(cnpj, 14);
        if (NumerosIguais(cnpj))
        {
            return false;
        }

        int[] array = new int[12]
        {
                5, 4, 3, 2, 9, 8, 7, 6, 5, 4,
                3, 2
        };
        int[] array2 = new int[13]
        {
                6, 5, 4, 3, 2, 9, 8, 7, 6, 5,
                4, 3, 2
        };
        cnpj = cnpj.Trim();
        if (cnpj.Length != 14)
        {
            return false;
        }

        string text = cnpj.Substring(0, 12);
        int num = 0;
        for (int i = 0; i < 12; i++)
        {
            num += int.Parse(text[i].ToString()) * array[i];
        }

        int num2 = num % 11;
        string text2 = ((num2 >= 2) ? (11 - num2) : 0).ToString();
        text += text2;
        num = 0;
        for (int j = 0; j < 13; j++)
        {
            num += int.Parse(text[j].ToString()) * array2[j];
        }

        num2 = num % 11;
        text2 += ((num2 >= 2) ? (11 - num2) : 0);
        return cnpj.EndsWith(text2);
    }

    private static string RemoverCaracteresEspeciais(string numero)
    {
        return Regex.Replace(numero, "[^0-9a-zA-Z]+", "");
    }

    private static string ZeroEsquerda(string numero, int qtdValorCompleto)
    {
        numero = numero.PadLeft(qtdValorCompleto, '0');
        return numero;
    }

    private static bool ValidarNumerico(string numero)
    {
        if (numero.All(char.IsDigit))
        {
            return true;
        }

        return false;
    }

    private static bool NumerosIguais(string numero)
    {
        char c = numero.ToString()[0];
        string text = numero.ToString();
        foreach (char c2 in text)
        {
            if (c != c2)
            {
                return false;
            }
        }

        return true;
    }

    public static string FormatarComPontuacao(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return string.Empty;
        }

        if (!ValidarNumerico(RemoverCaracteresEspeciais(s)))
        {
            return s;
        }

        s = RemoverCaracteresEspeciais(s);
        s = ZeroEsquerda(s, 14);
        if (s != null && s.Length == 14 && !s.Any((char c) => !char.IsDigit(c)))
        {
            return new string(new char[18]
            {
                    s[0],
                    s[1],
                    '.',
                    s[2],
                    s[3],
                    s[4],
                    '.',
                    s[5],
                    s[6],
                    s[7],
                    '/',
                    s[8],
                    s[9],
                    s[10],
                    s[11],
                    '-',
                    s[12],
                    s[13]
            });
        }

        return s;
    }

    public static string FormatarSemPontuacao(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return string.Empty;
        }

        if (!ValidarNumerico(RemoverCaracteresEspeciais(s)))
        {
            return s;
        }

        s = RemoverCaracteresEspeciais(s);
        return ZeroEsquerda(s, 14);
    }
}