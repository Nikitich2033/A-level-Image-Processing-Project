using System;
using System.Windows.Forms;

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
    }
}
