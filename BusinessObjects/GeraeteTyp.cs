using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class GeraeteTyp
    {
        public String GeraeteBezeichnung { get; set; }
        private int geraeteTypID;

        public int GeraeteTypID
        {
            get { return geraeteTypID; }
            set { geraeteTypID = value; }
       }
        private decimal mietPreis;

        public decimal MietPreis
        {
            get { return mietPreis; }
            set { mietPreis = value; }
        }
        public override string ToString()
        {
            return this.GeraeteBezeichnung;
        }

    }
}
