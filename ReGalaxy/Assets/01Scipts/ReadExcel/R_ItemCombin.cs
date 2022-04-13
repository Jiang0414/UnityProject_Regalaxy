using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_ItemCombin : MonoBehaviour
{
    public static R_ItemCombin _instance = null;
    public static List<ItemCombinData> itemCombinDatas;
    public static ItemCombin m_itemCombinData;

    public static R_ItemCombin Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new R_ItemCombin();
            }
            if (itemCombinDatas == null)
            {
                f_initPool();
                itemCombinDatas = m_itemCombinData.dataList;
            }
            return _instance;
        }
    }
    #region Åª¨úExcel
    public static void f_initPool()
    {
        m_itemCombinData = Resources.Load<ItemCombin>("Excel/Item/ItemCombin");
    }
    #endregion

    public string GetItemName(int ID)
    {
        string content = "";
        foreach (var value in itemCombinDatas)
        {
            if (value.Number == ID)
            {
                content = value.Name;
                break;
            }
        }
        return content;
    }
    public string GetItemType1(int ID)
    {
        string content = "";
        foreach (var value in itemCombinDatas)
        {
            if (value.Number == ID)
            {
                content = value.Type1;
                break;
            }
        }
        return content;
    }
    public string GetItemType2(int ID)
    {
        string content = "";
        foreach (var value in itemCombinDatas)
        {
            if (value.Number == ID)
            {
                content = value.Type2;
                break;
            }
        }
        return content;
    }
    public string GetItemType3(int ID)
    {
        string content = "";
        foreach (var value in itemCombinDatas)
        {
            if (value.Number == ID)
            {
                content = value.Type3;
                break;
            }
        }
        return content;
    }
    public string GetItemAmount1(int ID)
    {
        string content = "";
        foreach (var value in itemCombinDatas)
        {
            if (value.Number == ID)
            {
                content = value.Amount1;
                break;
            }
        }
        return content;
    }
    public string GetItemAmount2(int ID)
    {
        string content = "";
        foreach (var value in itemCombinDatas)
        {
            if (value.Number == ID)
            {
                content = value.Amount2;
                break;
            }
        }
        return content;
    }
    public string GetItemAmount3(int ID)
    {
        string content = "";
        foreach (var value in itemCombinDatas)
        {
            if (value.Number == ID)
            {
                content = value.Amount3;
                break;
            }
        }
        return content;
    }
}
