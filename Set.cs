namespace DataStructures.Collections.Sets;

public class Set<T>
{
    private List<T> _set;

    public Set()
    {
        this._set = new List<T>();
    }

    public List<T> Values
    {
        get { return this._set; }
        set { this._set = value; }
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
        if (Contains(item))
        {
            return;
        }

        this._set.Add(item);
    }

    public void Remove(T item)
    {
        this._set.Remove(item);
    }

    public void RemoveAt(int index)
    {
        this._set.RemoveAt(index);
    }

    public void Clear()
    {
        this._set.Clear();
    }

    public Set<T> Union(Set<T> otherSet)
    {
        Set<T> resultSet = new Set<T>();

        foreach (T item in this.Values)
        {
            resultSet.Add(item);
        }

        foreach (T item in otherSet.Values)
        {
            resultSet.Add(item);
        }

        return resultSet;
    }

    public Set<T> Intersection(Set<T> otherSet)
    {
        Set<T> resultSet = new Set<T>();

        foreach (T item in this.Values)
        {
            if (otherSet.Contains(item))
            {
                resultSet.Add(item);
            }
        }

        return resultSet;
    }

    public Set<T> Difference(Set<T> otherSet)
    {
        Set<T> resultSet = new Set<T>();

        foreach (T item in this.Values)
        {
            if (!otherSet.Contains(item))
            {
                resultSet.Add(item);
            }
        }

        return resultSet;
    }

    public bool IsSubsetOf(Set<T> otherSet)
    {
        foreach (T item in this.Values)
        {
            if (!otherSet.Contains(item))
            {
                return false;
            }
        }

        return true;
    }

    public bool IsSupersetOf(Set<T> otherSet)
    {
        foreach (T item in otherSet.Values)
        {
            if (Contains(item))
            {

            }
        }

        return true;
    }
}
