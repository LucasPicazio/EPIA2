using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace EPIA2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            CarregaBase();

        }

        private void CarregaBase()
        {
            var split = File.ReadAllLines(@"C:\Users\lucas\source\repos\EPIA2\EPIA2\Mails\Caixa de entrada.csv")
                  .Select(x => x.Split(';'));

                  var mails = split.Select(x => new email
                  {
                      Subject = x[1],
                      Body = x[2],
                      Spam = bool.Parse(x[3])
                  });
        }
    }
}
