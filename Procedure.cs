using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppWithAPIINtegration
{
    public class Procedure
    {
        private String treatment;
        public String Treatment { set { treatment = value; } get { return treatment; } }
        private String medication;
        public String Medication { set { medication = value; } get { return medication; } }
        private String dosageCycle;
        public String Dosage { set { dosageCycle = value; } get { return dosageCycle; } }
    }
}
