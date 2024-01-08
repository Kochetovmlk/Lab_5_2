using System.Collections;

namespace Task2;

public class MyList<T>:IEnumerable<T>
{
    private T[] _array;
    private int _size;
    private int _version;

    public MyList()
    {
        this._array = new T[] { };
        this._size = 0;
        this._version = 1;
    }

    public MyList(params T[] array)
    {
        this._array = array;
        this._size = array.Length;
        this._version = 1;
    }

    public MyList(int size)
    {
        this._array = new T[] { };
        this._size = size;
        this._version = 1;
    }

    public T this[int index]
    {
        get { return _array[index]; }
        set { this._array[index] = value; }
    }

    public int Length
    {
        get { return this._size; }
    }

    public void AddElem(T new_elem)
    {
        T[] new_arr = new T[this._size * 2];
        this._version++;
        this._array.CopyTo(new_arr, 0);
        new_arr[this._size] = new_elem;
        this._array = new_arr;
        this._size++;

    }
    public void Add(T new_elem)
    {
        AddElem(new_elem);
    }

    public void Print()
    {
        for (int i = 0; i < this._size; i++)
        {
            Console.Write(this._array[i] + " ");
        }
        Console.Write("\n");
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _array.ToList().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _array.GetEnumerator();
    }
}