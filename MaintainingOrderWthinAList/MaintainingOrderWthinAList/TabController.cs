using System.Collections;

public class TabController : IEnumerable<Tab>
{
    private readonly List<Tab> _tabs = new();

    public Tab OpenNew(string url)
    {
        var tab = new Tab(url);
        _tabs.Add(tab);
        Console.WriteLine($"OpenNew {tab}");
        return tab;
    }

    public void Close(Tab tab)
    {
        if (_tabs.Remove(tab))
        {
            Console.WriteLine($"Removed {tab}");
        }
    }

    public void MoveToStart(Tab tab)
    {
        if (_tabs.Remove(tab))
        {
            _tabs.Insert(0, tab);
            Console.WriteLine($"Moved {tab} to start");
        }
    }

    public void MoveToEnd(Tab tab)
    {
        if (_tabs.Remove(tab))
        {
            _tabs.Add(tab);
            Console.WriteLine($"Moved {tab} to end. Index={_tabs.IndexOf(tab)}");
        }
    }

    public void MoveToPosition(Tab tab, byte position)
    {
        if (_tabs.Remove(tab))
        {
            _tabs.Insert(position, tab);
            Console.WriteLine($"Moved {tab} to Index={_tabs.IndexOf(tab)}");
        }
    }

    public IEnumerator<Tab> GetEnumerator() => _tabs.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => _tabs.GetEnumerator();
}
