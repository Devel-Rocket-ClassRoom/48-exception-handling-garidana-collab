using System;

class InventoryFullException : Exception
{
    public int Capacity {get; set;}
    public string ItemName {get; set}
}

