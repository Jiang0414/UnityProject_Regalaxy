using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_ItemCombin : MonoBehaviour
{
    public static R_ItemCombin _instance = null;
    public static List<ItemCombinData> itemCombinDatas;
    public static ItemCombin m_itemCombinData;
    public static Dictionary<string, string> combineTypes;

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
    #region 讀取Excel
    public static void f_initPool()
    {
        m_itemCombinData = Resources.Load<ItemCombin>("Excel/Item/ItemCombin");
    }
    #endregion

    #region 獲取整列可抽取道具
    public void GetItemTypes(int id)
    {
        combineTypes = new Dictionary<string, string>();
        if (R_ItemCombin.Instance.GetItemType1(id) != "-")
        {
            Debug.Log("Type1");
            combineTypes.Add(R_ItemCombin.Instance.GetItemType1(id), R_ItemCombin.Instance.GetItemAmount1(id));
        }
        if (R_ItemCombin.Instance.GetItemType2(id) != "-")
        {
            Debug.Log("Type2");
            combineTypes.Add(R_ItemCombin.Instance.GetItemType2(id), R_ItemCombin.Instance.GetItemAmount2(id));
        }
        if (R_ItemCombin.Instance.GetItemType3(id) != "-")
        {
            Debug.Log("Type3");
            combineTypes.Add(R_ItemCombin.Instance.GetItemType3(id), R_ItemCombin.Instance.GetItemAmount3(id));
        }
        if (R_ItemCombin.Instance.GetItemType4(id) != "-")
        {
            Debug.Log("Type4" + R_ItemCombin.Instance.GetItemType4(id));
            combineTypes.Add(R_ItemCombin.Instance.GetItemType4(id), R_ItemCombin.Instance.GetItemAmount4(id));
        }
        if (R_ItemCombin.Instance.GetItemType5(id) != "-")
        {
            Debug.Log("Type5" + R_ItemCombin.Instance.GetItemType5(id));
            combineTypes.Add(R_ItemCombin.Instance.GetItemType5(id), R_ItemCombin.Instance.GetItemAmount5(id));
        }
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
    public string GetItemType4(int ID)
    {
        string content = "";
        foreach (var value in itemCombinDatas)
        {
            if (value.Number == ID)
            {
                content = value.Type4;
                break;
            }
        }
        return content;
    }
    public string GetItemType5(int ID)
    {
        string content = "";
        foreach (var value in itemCombinDatas)
        {
            if (value.Number == ID)
            {
                content = value.Type5;
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
    public string GetItemAmount4(int ID)
    {
        string content = "";
        foreach (var value in itemCombinDatas)
        {
            if (value.Number == ID)
            {
                content = value.Amount4;
                break;
            }
        }
        return content;
    }
    public string GetItemAmount5(int ID)
    {
        string content = "";
        foreach (var value in itemCombinDatas)
        {
            if (value.Number == ID)
            {
                content = value.Amount5;
                break;
            }
        }
        return content;
    }
}
