namespace PointAndClickEngine
{
    public class MainWindowController : IGameForm

    {
    private IGameForm _owner;

    public MainWindowController(IGameForm owner)
    {
        _owner = owner;
    }
    }
}