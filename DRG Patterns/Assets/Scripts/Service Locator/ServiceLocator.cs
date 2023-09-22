using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class ServiceLocator : MonoBehaviour
{
    //  Singleton Variables:
    private static ServiceLocator instance = null;

    //  Service Item Pool:
    private Dictionary<string, IServiceItem> items = new Dictionary<string, IServiceItem>();

    //  Getter:
    public static ServiceLocator Instance => instance;

    public void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Singleton already exists!!!");
            return;
        }
        instance = this;
    }

    public void Add(string key, IServiceItem item)
    {
        items.Add(key, item);
    }

    public IServiceItem Get(string key)
    {
        var retrievedItem = items[key];

        if (retrievedItem == null)
        {
            Debug.LogWarning("Key did not return a valid item!!!");
            return null;
        }
        return retrievedItem;
    }
}
