using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataViewer_D_v._001
{
    public partial class secretaryForm : Form
    {
        startWindow startWindow = new startWindow();

        public secretaryForm()
        {
            InitializeComponent();
        }

        private void CreateNewTournirButton_Click(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            startWindow.Show();

            startWindow.registratorButton.Visible = true;
            startWindow.secretaryButton.Visible = true;
            startWindow.Exit_button.Visible = true;

            startWindow.backButton.Visible = false;
            startWindow.solistButton.Visible = false;
            startWindow.duetButton.Visible = false;
            startWindow.sekwayButton.Visible = false;
            startWindow.ansamblButton.Visible = false;
        }

        private void secretaryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            startWindow.Show();

            startWindow.registratorButton.Visible = true;
            startWindow.secretaryButton.Visible = true;
            startWindow.Exit_button.Visible = true;

            startWindow.backButton.Visible = false;
            startWindow.solistButton.Visible = false;
            startWindow.duetButton.Visible = false;
            startWindow.sekwayButton.Visible = false;
            startWindow.ansamblButton.Visible = false;
        }
    }
}
