using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter:IPrinter //Implemento la interfaz Iprinter.
    {
        public void PrintTicket(Recipe receta)
        {
        File.WriteAllText("Ticket.txt", receta.GetTextToPrint());
        }
    }

}