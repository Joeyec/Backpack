using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;
using System.Text;

public class NewItemManager
{
    private static NewItemManager instance;
    public static NewItemManager Instance
    {
        get
        {
            if (instance == null) instance = new NewItemManager();
            return instance;
        }
    }
    public List<BackpackItem> BackpackItemList;
    private JsonData ItemConfig;
    public void LoadItemConfigData()
    {
        if (BackpackItemList == null)
        {
            BackpackItemList = new List<BackpackItem>();
        }
        this.ItemConfig=JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/Config/BackpackItem.json"));
        //, Encoding.GetEncoding("GB2312")

    }
    private void DecodeJson()
    {
        for (int i = 0; i < this.ItemConfig.Count; i++)
        {
            int itemID = (int)this.ItemConfig[i]["ItemID"];
            string itemName = ItemConfig[i]["ItemName"].ToString();
            string itemDesc = ItemConfig[i]["ItemDesc"].ToString();
            int itemType = (int)ItemConfig[i]["ItemType"];
            string itemIcon = ItemConfig[i]["ItemIcon"].ToString();
            string itemBgIcon = ItemConfig[i]["ItemBgIcon"].ToString();
            int itemCount = (int)ItemConfig[i]["ItemCount"];
            int itemQuality = (int)ItemConfig[i]["ItemQuality"];
            int itemOperation = (int)ItemConfig[i]["ItemOperation"];
            Debug.Log(itemID + " " + itemName + " " + itemDesc + " " + itemType + " " + itemIcon + " " + itemBgIcon + " " +
                itemCount + " " + itemQuality + " " + itemOperation);
            BackpackItem item = new BackpackItem(itemID, itemName, itemDesc, itemType, itemIcon, itemBgIcon, itemCount, itemQuality, itemOperation);
            BackpackItemList.Add(item);

        }
    }
}
 