using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Models;

// Wzorzec Projektowy Command (Komenda)
public interface ICommand
{
    void Execute();
    bool CanExecute();
}

public class ScanCommand : ICommand
{
    public bool CanExecute()
    {
        return true;
    }

    public void Execute()
    {

    }
}

public class PrintCommand : ICommand
{
    private readonly string barcode;
    private readonly BarcodePrinter printer;

    public PrintCommand(string barcode, BarcodePrinter printer)
    {
        this.barcode = barcode;
        this.printer = printer;
    }

    public bool CanExecute()
    {
        return printer.CanPrint();
    }

    public void Execute()
    {
        if (CanExecute())
            Console.WriteLine($"Printing {barcode} by {printer.Name}...");
    }
}

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
      
    }
}

public class PrinterManager
{
    public void PrintLabels()
    {
        var printer = new BarcodePrinter();

        PrintCommand command1 = new PrintCommand("123", printer);
        PrintCommand command2 = new PrintCommand("111", printer);
        PrintCommand command3 = new PrintCommand("222", printer);
        ScanCommand command4 = new ScanCommand();

        Queue<ICommand> commands = new Queue<ICommand>();

        commands.Enqueue(command1);
        commands.Enqueue(command2);
        commands.Enqueue(command3);
        commands.Enqueue(command4);

        while (commands.Count > 0)
        {
            ICommand command = commands.Dequeue();

            if (command.CanExecute())
                command.Execute();
        }


    }
}
