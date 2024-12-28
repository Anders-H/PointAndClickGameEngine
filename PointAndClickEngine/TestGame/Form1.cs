using System.Windows.Forms;
using PointAndClickEngine;

namespace TestGame
{
    public partial class Form1 : Form, IGameForm
    {
        public static IGameForm Controller { get; set; }

        public Form1()
        {
            InitializeComponent();
            Controller = new MainWindowController(this);
        }
    }
}s