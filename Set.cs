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
}
