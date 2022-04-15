using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_Buildings : MonoBehaviour
{
    public static R_Buildings _instance = null;
    public static List<BuildingData> buildDatas;
    public static Building m_BuildData;
    public static Dictionary<string, string> productions;
    public static Dictionary<string, string> expenditems;

    public static R_Buildings Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new R_Buildings();
            }
            if (buildDatas == null)
            {
                f_initPool();
                buildDatas = m_BuildData.dataList;
            }
            return _instance;
        }
    }
    #region Åª¨úExcel
    public static void f_initPool()
    {
        m_BuildData = Resources.Load<Building>("Excel/Building/Building");
    }
    #endregion

    public void GetProductions(int ID)
    {
        productions = new Dictionary<string, string>();
        string _content = GetBuildItem(ID);
        string[] cArray = _content.Split("#");
        string _amount = GetBuildItemValue(ID);
        string[] aArray = _amount.Split("#");

        for (int i = 0; i < cArray.Length; i++)
        {
            productions.Add(cArray[i], aArray[i]);
        }        
    }
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
        foreach (var value in buildDatas)
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
        foreach (var value in buildDatas)
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
        foreach (var value in buildDatas)
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
        foreach (var value in buildDatas)
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
        foreach (var value in buildDatas)
        {
            if (value.Number == ID)
            {
                content = value.Format;
                break;
            }
        }
        return content;
    }
    public string GetBuildEffect(int ID)
    {
        string content = "";
        foreach (var value in buildDatas)
        {
            if (value.Number == ID)
            {
                content = value.Effect;
                break;
            }
        }
        return content;
    }
    public string GetBuildItem(int ID)
    {
        string content = "";
        foreach (var value in buildDatas)
        {
            if (value.Number == ID)
            {
                content = value.Item1;
                break;
            }
        }
        return content;
    }
    public string GetBuildItemValue(int ID)
    {
        string content = "";
        foreach (var value in buildDatas)
        {
            if (value.Number == ID)
            {
                content = value.Itemvalue;
                break;
            }
        }
        return content;
    }
    public string GetBuildTime(int ID)
    {
        string content = "";
        foreach (var value in buildDatas)
        {
            if (value.Number == ID)
            {
                content = value.Time;
                break;
            }
        }
        return content;
    }
    public int GetBuildElectricity(int ID)
    {
        int content = 0;
        foreach (var value in buildDatas)
        {
            if (value.Number == ID)
            {
                content = value.Electricity;
                break;
            }
        }
        return content;
    }
    public int GetBuildJobs(int ID)
    {
        int content = 0;
        foreach (var value in buildDatas)
        {
            if (value.Number == ID)
            {
                content = value.Jobs;
                break;
            }
        }
        return content;
    }
    public string GetBuildExpendItem1(int ID)
    {
        string content = "" ;
        foreach (var value in buildDatas)
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
        foreach (var value in buildDatas)
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
        foreach (var value in buildDatas)
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
        foreach (var value in buildDatas)
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
        foreach (var value in buildDatas)
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
        foreach (var value in buildDatas)
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
