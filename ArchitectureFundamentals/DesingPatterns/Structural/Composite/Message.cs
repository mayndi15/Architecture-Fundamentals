using System.Collections;

namespace Architecture_Fundamentals.DesingPatterns.Structural.Composite;

public class Message : IMessage, IEnumerable<IMessage>
{
    private readonly List<IMessage> _list = new();

    public string Name { get; set; }

    public Message(string name)
    {
        Name = name;
    }

    public void Add(IMessage message)
    {
        _list.Add(message);
    }

    public void Remove(IMessage message)
    {
        _list.Remove(message);
    }

    public IMessage Find(int index)
    {
        return _list[index];
    }

    public IMessage FindByName(string name)
    {
        return _list.First(m => m.Name == name);
    }

    public IEnumerable<IMessage> FindAll()
    {
        return _list;
    }

    public void ShowMessage(int sub)
    {
        Console.WriteLine(new string('-', sub) + Name);

        foreach (var message in _list)
        {
            message.ShowMessage(sub + 2);
        }
    }

    public IEnumerator<IMessage> GetEnumerator()
    {
        return ((IEnumerable<IMessage>)_list).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<IMessage>)_list).GetEnumerator();
    }
}