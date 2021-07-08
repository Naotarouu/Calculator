using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class calClass
    {
        private Double value_result = 0;
        private String performing_operation = "";
        private bool performedOperation = false;

        public double Value_result 
        { 
            get => value_result; 
            set => value_result = value; 
        }

        public string Performing_operation 
        { 
            get => performing_operation; 
            set => performing_operation = value; 
        }

        public bool PerformedOperation 
        { 
            get => performedOperation; 
            set => performedOperation = value; 
        }
    }
}
