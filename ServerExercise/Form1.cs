using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceLibraryExercise;

namespace ServerExercise
{
    public partial class Form1 : Form
    {
        ServiceHost hostobjek = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOn.Enabled = true;
            btnOff.Enabled = false;
            txtServer.Enabled = false;
            txtServer.Text = "Server Off!!";           
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            btnOn.Enabled = false;
            btnOff.Enabled = true;
            hostobjek = new ServiceHost(typeof(Service1));
            hostobjek.Open();
            txtServer.Text = "Server ON!!";
            hostobjek.Close();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            btnOn.Enabled = true;
            btnOff.Enabled = false;
            hostobjek = null;
            txtServer.Text = "Server Off!!";
        }
    }
}
