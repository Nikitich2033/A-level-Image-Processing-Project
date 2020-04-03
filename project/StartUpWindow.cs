using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace project
{
    public partial class StartUpWindow : Form
    {
        public StartUpWindow()
        {
            InitializeComponent();
        }

        private void Start(object sender, EventArgs e)
        {
           
            var window = new MainWindow();
            this.Hide();
            window.ShowDialog();
            this.Close();
            
        }

        private void openReadme(object sender, EventArgs e)
        {
            Process.Start(@"assets\README.txt");
        }

    }
}
