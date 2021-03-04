using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_2.BehaviorPattern
{
    public interface IActionsCommand
    {
        void Execute();
        void Undo();
    }

    public class CommandPrint : IActionsCommand
    {
        List<Computer> computers;
        public CommandPrint(List<Computer> commputers)
        {
            this.computers = commputers;
           
        }
        public void Execute()
        {
            if (computers == null)
                return;
            Form4 LaboratoryDiagram = new Form4(computers);
            LaboratoryDiagram.Show();
        }

        public void Undo()
        {
            computers = new List<Computer>();
        }
    }

    public class CommandController
    {
        public IActionsCommand actionsCommand { get; set; }

        public void ShowLab()
        {
            if(actionsCommand!= null)
            actionsCommand.Execute();
        }
        public void UndoLab()
        {
            if (actionsCommand != null)
                actionsCommand.Undo();
        }
    }
}

