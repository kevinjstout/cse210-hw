using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new();

        while (menu._quit == false)
        {
            menu.DisplayAndPrompt();

            menu.ExecuteSelection();
        }
    }
}