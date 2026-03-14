using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;


class Inventory
{
    int maxCapacity;
    public Inventory(int cap)
    {
        maxCapacity = cap;
    }
    // 리스트를 선언만 하면 null 상태가 되므로
    // 일단 빈 배열로 생성
    List<string> items = new List<string>();

    public void AddItem(string itemName)
    {
        if (items.Count >= maxCapacity)
        {
            throw new InventoryFullException(items.Count, itemName);
        }
        items.Add(itemName);
    }

    public void RemoveItem(string itemName)
    {
        if (!items.Contains(itemName))
        {
            throw new ItemNotFoundException(itemName);
        }
        items.Remove(itemName);
    }
    public void ShowItem()
    {
        string curInv = string.Join(", ", items);
        WriteLine($"현재 인벤토리: {curInv}");
    }
}
