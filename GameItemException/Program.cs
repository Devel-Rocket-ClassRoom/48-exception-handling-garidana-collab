using System;
using System.Collections.Generic;
using static System.Console;

// 인벤토리 생성자에서 이미 할당함으로 필요 없음.
// List<string> Inventory = new List<string>();

Inventory inv = new Inventory(3);

WriteLine("=== 인벤토리 테스트 ===");
InvTryCatchAdd("검");
InvTryCatchAdd("방패");
InvTryCatchAdd("포션");
InvTryCatchAdd("활");

WriteLine();

inv.ShowItem();
RemoveTryCatch("포션");
RemoveTryCatch("도끼");

WriteLine();

inv.ShowItem();


void InvTryCatchAdd (string itemName)
{
    try { inv.AddItem(itemName); }
    catch (InventoryFullException e) { WriteLine($"[인벤토리 오류] {e.Message}"); }
}

void RemoveTryCatch (string itemName)
{
    try { inv.RemoveItem(itemName); }
    catch (ItemNotFoundException e) { WriteLine($"[인벤토리 오류] {e.Message}"); }
}