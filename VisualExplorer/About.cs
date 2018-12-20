using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace VisualExplorer
{
    
    public partial class aboutForm : Form
    {
        string currentVersion = "1.0.0";
        public aboutForm()
        {
            InitializeComponent();
        }

        private void aboutLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uri resultUri =  new Uri("https://github.com/SangMinhTruong/visual-explorer/blob/master/Setup/_version_.txt");
            using (WebClient wc = new WebClient())
            {
              
                wc.DownloadFileAsync(
                    resultUri
               // Param1 = Link of file
               ,
               // Param2 = Path to save

               "update.txt"
                );
            }
        }
    }
}
