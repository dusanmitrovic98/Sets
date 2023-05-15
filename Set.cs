namespace DataStructures.Collections.Sets;

public class Set<T>
{
    private List<T> _set;

    public Set()
    {
        this._set = new List<T>();
    }

    public int Count
    {
        get { return this._set.Count; }
    }

    public bool Contains(T item)
    {
        return this._set.Contains(item);
    }

    public void Add(T item)
    {
        throw new NotImplementedException();
    }
}
