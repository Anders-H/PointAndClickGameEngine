using System.Windows.Forms;
using PointAndClickEngine;

namespace TestGame
{
    public partial class Form1 : Form
    {
        public static MainWindowController Controller { get; set; }

        public Form1()
        {
            InitializeComponent();
            Controller = new MainWindowController(this, 640, 400);
            Controller.CurrentScene = new StampScene();
        }

        private void optionStamp_CheckedChanged(object sender, System.EventArgs e)
        {
            if (optionStamp.Checked)
                Controller.CurrentScene = new StampScene();
        }
    }
}