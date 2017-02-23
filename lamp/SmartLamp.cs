using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lamp
{
    class SmartLamp
    {
        private bool brandend = false;
        private TimeSpan brandTijd;
        private DateTime startTijd;

        public SmartLamp()
        {
            startTijd = DateTime.Now;
        }

        public void Toggle()
        {
            brandend = !brandend;
        }
        
        public bool Brandend
        {
            get
            {
                return brandend;
            }
        }

        public TimeSpan BrandTijd
        {
            get
            {
                brandTijd = DateTime.Now - startTijd;
                startTijd = DateTime.Now;
                return brandTijd;
            }
        }
    }
}