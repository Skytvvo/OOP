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
            if(!(processor.Bits.BitArchitecture == Bits.processorBit.x32 ||
                processor.Bits.BitArchitecture == Bits.processorBit.x64))
            {
                this.ErrorMessage += "Некорректная архетекруа\n";
                ErrorFlag = true;
                //return false;
            }
            if(!(processor.Power.Cores >= 1 && processor.Power.Cores <= 100))
            {
                this.ErrorMessage += "Некорректно введено количество ядер\n";
                ErrorFlag = true;

                // return false;
            }
            if (!(processor.Power.Frenquecy >= 1 && processor.Power.Frenquecy <= 9000))
            {
                this.ErrorMessage += "Некорректное значение частоты процессора\n";
                ErrorFlag = true;

                // return false;
            }
            if ((processor.Manufactur.man == null))
            {
                this.ErrorMessage += "Некорректное название производителя\n";
                ErrorFlag = true;

                // return false;
            }
            if ((processor.Manufactur.Model == null ))
            {
                this.ErrorMessage += "Некорректное название модели\n";
                ErrorFlag = true;

                // return false;
            }
            if ((processor.Manufactur.Series == null))
            {
                this.ErrorMessage += "Некорректное название серии\n";
                ErrorFlag = true;

                // return false;
            }
            if (!(processor.Cache.L1 >= 1))
            {
                this.ErrorMessage += "Некорректно введено значение кеша L1\n";
                ErrorFlag = true;

                //return false;
            }
            if (!(processor.Cache.L2 >= 1))
            {
                this.ErrorMessage += "Некорректно введено значение кеша L2\n";
                ErrorFlag = true;
                
                // return false;
            }
            if (!(processor.Cache.L3 >= 1))
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
