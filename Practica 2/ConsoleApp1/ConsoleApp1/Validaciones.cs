using System;
using System.Collections.Generic;
using System.Text;

class Validaciones
{
    static bool ValidarNombre(string n)
    {
        int c = 0;
        bool r = false;
        byte[] ascii = Encoding.ASCII.GetBytes(n);
        foreach (byte b in ascii)
        {
            if(b >= 97 && b <= 122 || b >= 65 && b <= 90 || b == 32)
            {
                c++;
            }
        }
        if(c == n.Length)
        {
            r = true;
        }
        else
        {
            r = false;
        }
        return r;
    }

    static bool ValidarEdad(string e)
    {
        bool r = false;
        try
        {
            int edad = int.Parse(e);
            if (edad >= 18 && edad <= 99)
            {
                r = true;
            }
        }
        catch
        {
            r = false;
        }
        return r;
    }

    static bool ValidarTelefono(string t)
    {
        bool r = false;
        try 
        {
            if (t.Length == 10)
            {
                int telef = int.Parse(t);
                r = true;
            }
        }
        catch
        {
            r = false;
        }
        return r;
    }

    static bool ValidarContrasena(string co)
    {
        bool r = false;
        int c = 0;
        int minu = 0;
        int mayus = 0;
        int nume = 0;
        byte[] ascii = Encoding.ASCII.GetBytes(co);
        if (co.Length >= 8)
        {
            foreach (byte b in ascii)
            {
                if (b >= 65 && b <= 90)
                {
                    c++;
                    mayus++;
                }
                if (b >= 97 && b <= 122)
                {
                    c++;
                    minu++;
                }
                if (b >= 48 && b <= 57)
                {
                    c++;
                    nume++;
                }
            }
        }
        if(c == co.Length && minu >= 1 && mayus >=1 && nume >= 1)
        {
            r = true;
        }
        else
        {
            r = false;
        }

        return r;
    }

    static bool ValidarCorreo(string cor)
    {
        bool r = false;
        int c = 0;
        int a = 0;
        int p = 0;
        byte[] ascii = Encoding.ASCII.GetBytes(cor);
        foreach(byte b in ascii)
        {
            if (b >= 97 && b <= 122 || b >= 48 && b <= 57)
            {
                c++;
            }
            if (b== 46)
            {
                p++;
                c++;
            }
            if(b== 64)
            {
                a++;
                c++;
            }
        }
        if( c == cor.Length && p == 1 && a == 1)
        {
            r = true;
        }
        else
        {
            r = false;
        }
        return r;
    }
}
