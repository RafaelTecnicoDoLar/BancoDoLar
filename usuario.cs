using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_Do_Lar
{
    public partial class usuario : Form
    {
        public usuario()
        {
            InitializeComponent();

            string usuario = "";
            Console.WriteLine("Insira o Usuario");
            usuario = Console.ReadLine();

        }
    }
}
