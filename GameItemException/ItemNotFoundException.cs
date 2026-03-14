using System;
using static System.Console;

class ItemNotFoundException : Exception
{
    public string ItemName {get; set;}

    public ItemNotFoundException(string itemName)
       : base ($"아이템을 찾을 수 없습니다: {itemName}")
    {
        ItemName = itemName;
    }

}