public abstract class Menu
{
    protected bool _isRunning;

    protected bool _isQuit;

    public Menu()
    {
        _isRunning = true;

        _isQuit = false;
    }
    
    public abstract void Display();

    public bool IsRunning()
    {
        return _isRunning;
    }
    public bool IsQuit()
    {
        return _isQuit;
    }
}