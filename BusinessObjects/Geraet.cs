using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Geraet
    {
        private String anschaffungsjahr;

        public String Anschaffungsjahr
        {
            get { return anschaffungsjahr; }
            set { anschaffungsjahr = value; }
        }
        private String baujahr;

        public String Baujahr
        {
            get { return baujahr; }
            set { baujahr = value; }
        }
        private Int32 geraeteId;

        public Int32 GeraeteId
        {
            get { return geraeteId; }
            set { geraeteId = value; }
        }
        private Int32 typId;

        public Int32 TypId
        {
            get { return typId; }
            set { typId = value; }
        }
        public Geraet()
        {

        }
        public Geraet( Int32 id,string anschaffungsjahr, string baujahr,Int32 typID)
        {
            this.GeraeteId = id;
            this.Anschaffungsjahr = anschaffungsjahr;
            this.Baujahr = baujahr;
            this.TypId = typID;
        }
        public override string ToString()
        {
            return this.TypId.ToString() + " - " + this.Baujahr;
        }
    }
}
