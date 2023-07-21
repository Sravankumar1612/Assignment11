/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class LargeDataCollection
    {
    }
}
*/
using System;
using System.Collections.Generic;

public class LargeDataCollection : IDisposable
{
    private List<int> data;

    public LargeDataCollection(IEnumerable<int> initialData)
    {
        data = new List<int>(initialData);
    }

    public void Add(int item)
    {
        data.Add(item);
    }

    public void Remove(int item)
    {
        try
        {
            //data.RemoveAt(data.IndexOf(item));
            data.Remove(data[item]);
        }
        catch(ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public void Display()
    {
        Console.WriteLine("items in list are") ;
        foreach (var item in data)
        {
            Console.Write(item+"\t");
        }
    }

    public int GetElementAt(int index)
    {
        if (index < 0 || index >= data.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        return data[index];
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            // Release managed resources here, if any
            data.Clear();
            Console.WriteLine("\nThe data is disposed");
            data = null;
        }

        // Release any unmanaged resources here, if any
    }
}