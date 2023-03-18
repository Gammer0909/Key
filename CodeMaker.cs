using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeMaker;

public class Coder 
{

    static string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+{}|:<>?"; // (26 * 2) + 20 = 72 
    public static string createdCode = "";

    public static string CreateCode(int codeLength)
    {

        Random rng = new Random();
        int max = chars.Length - 1;
        for (int i = 0; i < codeLength; i++)
        {

            int index = rng.Next(0, max);
            char c = chars[index];
            createdCode += c;

        }
        return createdCode;

     }
        

}

