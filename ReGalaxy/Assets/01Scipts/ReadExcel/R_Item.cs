using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_Item : MonoBehaviour
{
    public static R_Item _instance = null;
    public static List<ItemData> itemDatas;
    public static Item m_itemData;

    public static R_Item Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new R_Item();
            }
            if (itemDatas == null)
            {
                f_initPool();
                itemDatas = m_itemData.dataList;
            }
            return _instance;
        }
    }
    #region Åª¨úExcel
    public static void f_initPool()
    {
        m_itemData = Resources.Load<Item>("Excel/Item/Item");
    }
    #endregion
    public int GetItemID(string ItemNumber)
    {
        int Number = 0;
        foreach (var value in itemDatas)
        {
            if (value.Number == int.Parse(ItemNumber))
            {
                Number = value.Number;
            }
        }
        return Number;
    }
    public string GetItemName(int ID)
    {
        string content = "";
        foreach (var value in itemDatas)
        {
            if (value.Number == ID)
            {
                content = value.Name;
                break;
            }
        }
        return content;
    }
    public string GetItemIcon(int ID)
    {
        string content = "";
        foreach (var value in itemDatas)
        {
            if (value.Number == ID)
            {
                content = value.Icon;
                break;
            }
        }
        return content;
    }
    public string GetItemType(int ID)
    {
        string content = "";
        foreach (var value in itemDatas)
        {
            if (value.Number == ID)
            {
                content = value.Type;
                break;
            }
        }
        return content;
    }
    public string GetItemValue(int ID)
    {
        string content = "";
        foreach (var value in itemDatas)
        {
            if (value.Number == ID)
            {
                content = value.Value1;
                break;
            }
        }
        return content;
    }
    public string GetItemContent(int ID)
    {
        string content = "";
        foreach (var value in itemDatas)
        {
            if (value.Number == ID)
            {
                content = value.Content;
                break;
            }
        }
        return content;
    }
}
