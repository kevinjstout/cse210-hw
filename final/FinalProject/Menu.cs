public abstract class Menu
{
    protected bool _isQuit;

    public Menu()
    {
        _isQuit = false;
    }
    
    public abstract void Display(string loser);
}