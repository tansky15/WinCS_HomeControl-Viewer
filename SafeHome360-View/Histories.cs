using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeHome360_View
{
    public partial class Histories : Form
    {
        myHouseEntities dbMaisons;
        public Histories()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadViews(Int32 i)
        {
            var info = dbMaisons.histories.ToList().ElementAt(i);
            string sms = info.message;

            histList.Items.Add(sms);

        }
        private void Histories_Load(object sender, EventArgs e)
        {
            dbMaisons = new myHouseEntities();
            Int32 nbrInfos = dbMaisons.histories.Count();

            for (Int32 i=0; i < nbrInfos; i++)
            {
                LoadViews(i);
            }


        }
    }
}
