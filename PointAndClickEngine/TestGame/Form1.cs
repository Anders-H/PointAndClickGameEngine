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
            Controller = new MainWindowController(this, 320, 200);
        }
    }
}