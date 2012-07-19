﻿using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        CommandLineInterpreter oCLI = new CommandLineInterpreter();
        ActionCallingContext acc = new ActionCallingContext();

        acc.AddParameter("CONFIGSCHEME", "Standard");
        acc.AddParameter("FILTERSCHEME", "Allpolig");

        oCLI.Execute("compress", acc);

        MessageBox.Show("Action ausgeführt.");

        return;
    }
}
