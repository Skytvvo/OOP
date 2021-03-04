using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_2.StructurePattern
{
    public interface ICheckEquipment
    {
        bool EquipError();
        void NeedToRepair();

    }

    public interface IProcessorUnite
    {
        bool CheckProps();
    }

    public class Admin
    {
        public void StartDiagnostic(ICheckEquipment equipment)
        {
            if (!equipment.EquipError())
                equipment.NeedToRepair();
        }
    }

    public class ProcessorToEquipmentAdapter : ICheckEquipment
    {

        Processor Processor;

        public ProcessorToEquipmentAdapter(Processor processor)
        {
            this.Processor = processor;
        }

        public bool EquipError()
        {
            return this.Processor.CheckProps();
        }

        public void NeedToRepair()
        {
            MessageBox.Show($"Equipment:{this.Processor.GetType()} ({this.Processor.Manufactur.man}, {this.Processor.Manufactur.Model}) need to reapir");
        }
    }


}
