using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorData : MonoBehaviour
{
    protected int x, y;
    protected int range;
}

public class FloorInfo : FloorData
{
    public FloorInfo(int _x, int _y, int _range)
    {
        x = _x;
        y = _y;
        range = _range;
    }

    public int X
    {
        get { return x; }
        set { x = value; }
    }
    public int Y
    {
        get { return y; }
        set { y = value; }
    }
    public int Range
    {
        get { return range; }
        set { range = value; }
    }
}
