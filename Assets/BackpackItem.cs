using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BackpackItem 
{
    public enum ItemType
    {
        UnKnown = -1,
        Equip,
        Chips,
    }
    public int ItemID;
    public ItemType itemType = ItemType.UnKnown;
    public string ItemName;
    public string ItemDesc;
    public string ItemIcon;
    public string ItemBgIcon;
    public int ItemCount;
    public int ItemQua;

    public int ItemOperation;
    public BackpackItem(int itemid,string name,string desc,int itemtype,string icon,string bgicon,int count,int quality,int operation)
    {
        ItemID = itemid;
        ItemName = name;
        ItemDesc = desc;
        switch (itemtype)
        {
            case -1:
                itemType = ItemType.UnKnown;
                break;
            case 0:
                itemType = ItemType.Equip;
                break;
            case 1:
                itemType = ItemType.Chips;
                break;
        }
        ItemIcon = icon;
        ItemBgIcon = bgicon;
        ItemCount = count;
        ItemQua = quality;
        ItemOperation = operation;

    }
}
