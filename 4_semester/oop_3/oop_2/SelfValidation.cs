using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    public class SelfValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool ErrorFlag = false;

            Processor processor = value as Processor;
            if(!(processor.BitArchitecture == Processor.processorBit.x32 ||
                processor.BitArchitecture == Processor.processorBit.x64))
            {
                this.ErrorMessage += "Некорректная архетекруа\n";
                ErrorFlag = true;
                //return false;
            }
            if(!(processor.Cores >= 1 && processor.Cores <= 100))
            {
                this.ErrorMessage += "Некорректно введено количество ядер\n";
                ErrorFlag = true;

                // return false;
            }
            if (!(processor.Frenquecy >= 1 && processor.Frenquecy <= 5000))
            {
                this.ErrorMessage += "Некорректное значение частоты процессора\n";
                ErrorFlag = true;

                // return false;
            }
            if ((processor.Manufactor == null))
            {
                this.ErrorMessage += "Некорректное название производителя\n";
                ErrorFlag = true;

                // return false;
            }
            if ((processor.Model == null ))
            {
                this.ErrorMessage += "Некорректное название модели\n";
                ErrorFlag = true;

                // return false;
            }
            if ((processor.Series == null))
            {
                this.ErrorMessage += "Некорректное название серии\n";
                ErrorFlag = true;

                // return false;
            }
            if (!(processor.sizeL1 >= 1))
            {
                this.ErrorMessage += "Некорректно введено значение кеша L1\n";
                ErrorFlag = true;

                //return false;
            }
            if (!(processor.sizeL2 >= 1))
            {
                this.ErrorMessage += "Некорректно введено значение кеша L2\n";
                ErrorFlag = true;
                
                // return false;
            }
            if (!(processor.sizeL3 >= 1))
            {
                this.ErrorMessage += "Некорректно введено значение кеша L3\n";
                ErrorFlag = true;

                //  return false;
            }
            if (ErrorFlag)
                return false;
            return true;
        }
    }
}
