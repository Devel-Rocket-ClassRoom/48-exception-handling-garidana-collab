using System;
using System.Collections.Generic;
using static System.Console;

// 인벤토리 생성자에서 이미 할당함으로 필요 없음.
// List<string> Inventory = new List<string>();

Inventory inv = new Inventory(3);

WriteLine("=== 인벤토리 테스트 ===");
inv.AddItem("검");
inv.AddItem("방패");
inv.AddItem("포션");
try
{
    inv.AddItem("활");
}
catch (InventoryFullException e)
{
    WriteLine($"[인벤토리 오류] {e.Message}");
}
WriteLine();
inv.ShowItem();
inv.RemoveItem("포션");
try
{
    inv.RemoveItem("Dok2");
}
catch (ItemNotFoundException e)
{
    WriteLine($"[인벤토리 오류] {e.Message}");
}
