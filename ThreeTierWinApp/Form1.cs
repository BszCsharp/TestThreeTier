using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObjects;
using BusinessTier;

namespace ThreeTierWinApp
{
    public partial class Form1 : Form
    {
        List<GeraeteTyp> listGeraeteTypen = null;
        Service s = new Service();
        public Form1()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
           
            listGeraeteTypen = s.getAlleGeraeteTypen();
            listBoxGeraeteTypen.DataSource = listGeraeteTypen;
        }

        private void listBoxGeraeteTypen_SelectedIndexChanged(object sender, EventArgs e)
        {
            GeraeteTyp gt = (GeraeteTyp)listBoxGeraeteTypen.SelectedItem;
            //listBoxGeraete.DataSource = null;
            listBoxGeraete.DataSource = s.getAlleGeraeteFromTeraeteTyp(gt.GeraeteTypID);

        }

    }
}
