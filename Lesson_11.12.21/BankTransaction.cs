using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson_11._12._21
{
    public class BankTransaction
    {
        private readonly decimal summa;
        private readonly DateTime when;
        public decimal Summa { get { return summa; } }
        public DateTime When { get { return when; } }
        public BankTransaction(decimal summa)
        {
            this.summa = summa;
            when = DateTime.Now;
        }
    }
}
