using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_LoginSystem : MonoBehaviour
{
    public static R_LoginSystem _instance = null;
    public static List<LoginMissionData> loginDatas;
    public static LoginMission m_LoginData;

    public static R_LoginSystem Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new R_LoginSystem();
            }
            if (loginDatas == null)
            {
                f_initPool();
                loginDatas = m_LoginData.dataList;
            }
            return _instance;
        }
    }
    #region Åª¨úExcel
    public static void f_initPool()
    {
        m_LoginData = Resources.Load<LoginMission>("Excel/Login/LoginMission");
    }
    #endregion

    public int GetLoginID(string ItemNumber)
    {
        int Number = 0;
        foreach (var value in loginDatas)
        {
            if (value.Number == int.Parse(ItemNumber))
            {
                Number = value.Number;
            }
        }
        return Number;
    }
    public int GetLoginDay(string ItemNumber)
    {
        int Number = 0;
        foreach (var value in loginDatas)
        {
            if (value.Number == int.Parse(ItemNumber))
            {
                Number = value.Day;
            }
        }
        return Number;
    }
    public string GetItemType1(int ID)
    {
        string content = "";
        foreach (var value in loginDatas)
        {
            if (value.Number == ID)
            {
                content = value.Itemtype1;
                break;
            }
        }
        return content;
    }
    public string GetItemNumber1(int ID)
    {
        string content = "";
        foreach (var value in loginDatas)
        {
            if (value.Number == ID)
            {
                content = value.Itemnumber1;
                break;
            }
        }
        return content;
    }
    public string GetItemAmount1(int ID)
    {
        string content = "";
        foreach (var value in loginDatas)
        {
            if (value.Number == ID)
            {
                content = value.Itemamount1;
                break;
            }
        }
        return content;
    }
    public string GetItemType2(int ID)
    {
        string content = "";
        foreach (var value in loginDatas)
        {
            if (value.Number == ID)
            {
                content = value.Itemtype2;
                break;
            }
        }
        return content;
    }
    public string GetItemNumber2(int ID)
    {
        string content = "";
        foreach (var value in loginDatas)
        {
            if (value.Number == ID)
            {
                content = value.Itemnumber2;
                break;
            }
        }
        return content;
    }
    public string GetItemAmount2(int ID)
    {
        string content = "";
        foreach (var value in loginDatas)
        {
            if (value.Number == ID)
            {
                content = value.Itemamount2;
                break;
            }
        }
        return content;
    }
}
