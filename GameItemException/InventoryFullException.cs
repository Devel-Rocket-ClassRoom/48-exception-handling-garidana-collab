using System;

class InventoryFullException : Exception
{
    public int Capacity {get;}
    public string ItemName { get;}

    public InventoryFullException(int cap, string itemName)
        : base($"인벤토리가 가득 찼습니다. (용량: {cap}, 아이템: {itemName})")
    {
        Capacity = cap;
        ItemName = itemName;
    }
}

