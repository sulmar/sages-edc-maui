using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models;

public class BarcodePrinter
{
    public string Name { get; set; }

    private bool isEnabled;

    public void Enable()
    {
        isEnabled = true;
    }

    public bool CanPrint()
    {
        return isEnabled;
    }

    public void Print(string barcode)
    {
        if (CanPrint())
            Console.WriteLine($"Printing {barcode} by {Name}...");
    }
}

public class PrinterManager
{

    public void PrintLabels()
    {
        var printer = new BarcodePrinter();
        printer.Print("123");
        printer.Print("111");
        printer.Print("222");
    }
}
