using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeInfo
{
    protected int _ID;
    protected int _Lv;
    protected string _Type;
    protected string _Name;
    protected string _Format;
    protected Dictionary<string, string> _ExpendItems;
}
public class UpgradeDatas : UpgradeInfo
{
    public UpgradeDatas(int id, int lv, string type, string name, string format, Dictionary<string, string> expendItems)
    {
        this._ID = id;
        this._Lv = lv;
        this._Type = type;
        this._Name = name;
        this._Format = format;
        this._ExpendItems = expendItems;
    }
    public int ID
    {
        get { return this._ID; }
        set { this._ID = value; }
    }
    public int Lv
    {
        get { return this._Lv; }
        set { this._Lv = value; }
    }
    public string Type
    {
        get { return this._Type; }
        set { this._Type = value; }
    }
    public string Name
    {
        get { return this._Name; }
        set { this._Name = value; }
    }
    public string Format
    {
        get { return this._Format; }
        set { this._Format = value; }
    }
    public Dictionary<string, string> ExpendItems
    {
        get { return this._ExpendItems; }
        set { this._ExpendItems = value; }
    }
}
