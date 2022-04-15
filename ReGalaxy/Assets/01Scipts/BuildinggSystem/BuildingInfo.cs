using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingInfo
{
    protected int _ID;
    protected int _Lv;
    protected string _Type;
    protected string _Name;
    protected string _Format;
    protected string _Effect;
    protected Dictionary<string, string> _Productions;
    protected string _Time;
    protected int _Electricity;
    protected int _Jobs;
    protected Dictionary<string, string> _ExpendItems;
}

public class BuildingDatas : BuildingInfo
{
    public BuildingDatas(int id, int lv, string type, string name, string format, string effect
        , Dictionary<string, string> prductions, string time, int electricity, int jobs, Dictionary<string, string> expendItems)
    {
        this._ID = id;
        this._Lv = lv;
        this._Type = type;
        this._Name = name;
        this._Format = format;
        this._Effect = effect;
        this._Productions = prductions;
        this._Time = time;
        this._Electricity = electricity;
        this._Jobs = jobs;
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
    public string Effect
    {
        get { return this._Effect; }
        set { this._Effect = value; }
    }
    public Dictionary<string, string> Productions
    {
        get { return this._Productions; }
        set { this._Productions = value; }
    }
    public string Time
    {
        get { return this._Time; }
        set { this._Time = value; }
    }
    public int Electricity
    {
        get { return this._Electricity; }
        set { this._Electricity = value; }
    }
    public int Jobs
    {
        get { return this._Jobs; }
        set { this._Jobs = value; }
    }
    public Dictionary<string, string> ExpendItems
    {
        get { return this._ExpendItems; }
        set { this._ExpendItems = value; }
    }
}
