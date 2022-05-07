using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter:IPrinter //Implemento la interfaz Iprinter.
    {
        public void PrintTicket(Recipe receta)
        {
        Console.WriteLine(receta.GetTextToPrint());
        }

    }
}