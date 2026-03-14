using System;
using System.Collections.Generic;
using System.Text;

class Inventory
{
    int MaxCapacity;
    public Inventory(int cap)
    {
        MaxCapacity = cap;
    }
    List<string> items;

    public void AddIItem(string itemName)
    {
        items.Add(itemName);
    }

    public void RemoveItem(string itemName)
    {
        
    }
    public void ShowItem()
    {

    }
}
