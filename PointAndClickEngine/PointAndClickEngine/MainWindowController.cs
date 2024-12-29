using System.Windows.Forms;

namespace PointAndClickEngine
{
    public class MainWindowController
    {
        private readonly Form _owner;


        public MainWindowController(Form owner)
        {
            _owner = owner;
            _owner.Paint += DoPaint;
        }

        private void DoPaint(object sender, PaintEventArgs e)
        {

        }
    }
}