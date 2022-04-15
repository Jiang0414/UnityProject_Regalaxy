using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_Upgrades : MonoBehaviour
{
    public static R_Upgrades _instance = null;
    public static List<UpgradeData> upgradeDatas;
    public static Upgrade m_UpgradesData;
    public static Dictionary<string, string> expenditems;
    public static R_Upgrades Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new R_Upgrades();
            }
            if (upgradeDatas == null)
            {
                f_initPool();
                upgradeDatas = m_UpgradesData.dataList;
            }
            return _instance;
        }
    }
    #region Åª¨úExcel
    public static void f_initPool()
    {
        m_UpgradesData = Resources.Load<Upgrade>("Excel/Building/Upgrade");
    }
    #endregion
    public void GetExpenditems(int ID)
    {
        expenditems = new Dictionary<string, string>();
        expenditems.Add(GetBuildExpendItem1(ID), GetBuildExpendAmount1(ID));
        expenditems.Add(GetBuildExpendItem2(ID), GetBuildExpendAmount2(ID));
        expenditems.Add(GetBuildExpendItem3(ID), GetBuildExpendAmount3(ID));
    }
    public int GetBuildID(string ItemNumber)
    {
        int Number = 0;
        foreach (var value in upgradeDatas)
        {
            if (value.Number == int.Parse(ItemNumber))
            {
                Number = value.Number;
            }
        }
        return Number;
    }
    public int GetBuildLv(int ID)
    {
        int Lv = 0;
        foreach (var value in upgradeDatas)
        {
            if (value.Number == ID)
            {
                Lv = value.Lv;
            }
        }
        return Lv;
    }
    public string GetBuildType(int ID)
    {
        string content = "";
        foreach (var value in upgradeDatas)
        {
            if (value.Number == ID)
            {
                content = value.Type;
                break;
            }
        }
        return content;
    }
    public string GetBuildName(int ID)
    {
        string content = "";
        foreach (var value in upgradeDatas)
        {
            if (value.Number == ID)
            {
                content = value.Name;
                break;
            }
        }
        return content;
    }
    public string GetBuildFormat(int ID)
    {
        string content = "";
        foreach (var value in upgradeDatas)
        {
            if (value.Number == ID)
            {
                content = value.Format;
                break;
            }
        }
        return content;
    }
    public string GetBuildExpendItem1(int ID)
    {
        string content = "";
        foreach (var value in upgradeDatas)
        {
            if (value.Number == ID)
            {
                content = value.Expenditem1;
                break;
            }
        }
        return content;
    }
    public string GetBuildExpendAmount1(int ID)
    {
        string content = "";
        foreach (var value in upgradeDatas)
        {
            if (value.Number == ID)
            {
                content = value.Expendamount1;
                break;
            }
        }
        return content;
    }
    public string GetBuildExpendItem2(int ID)
    {
        string content = "";
        foreach (var value in upgradeDatas)
        {
            if (value.Number == ID)
            {
                content = value.Expenditem2;
                break;
            }
        }
        return content;
    }
    public string GetBuildExpendAmount2(int ID)
    {
        string content = "";
        foreach (var value in upgradeDatas)
        {
            if (value.Number == ID)
            {
                content = value.Expendamount2;
                break;
            }
        }
        return content;
    }
    public string GetBuildExpendItem3(int ID)
    {
        string content = "";
        foreach (var value in upgradeDatas)
        {
            if (value.Number == ID)
            {
                content = value.Expenditem3;
                break;
            }
        }
        return content;
    }
    public string GetBuildExpendAmount3(int ID)
    {
        string content = "";
        foreach (var value in upgradeDatas)
        {
            if (value.Number == ID)
            {
                content = value.Expendamount3;
                break;
            }
        }
        return content;
    }
}
