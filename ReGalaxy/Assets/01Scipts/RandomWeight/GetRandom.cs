using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRandom : MonoBehaviour
{
    public static GetRandom _instance = null;
    public static Dictionary<string, float> weightDict = new Dictionary<string, float>();

    public static GetRandom Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GetRandom();
            }
            return _instance;
        }
    }

    private void LoadWeight(int ID , string content)
    {
        string _content = content; //R_ItemCombin.Instance.GetItemType1(ID)
        string[] cArray = _content.Split("#");
        foreach (var c in cArray)
        {
            string[] idWeight = c.Split("/");
            weightDict.Add(idWeight[0], float.Parse(idWeight[1]));
        }
    }

    private float GetTotalWeight()
    {
        float totalWeight = 0;
        foreach (var weight in weightDict.Values)
        {
            totalWeight += weight;
        }
        return totalWeight;
    }

    public string GetRandomValue(int id, string content)
    {
        LoadWeight(id, content);
        string itemName = "";
        float ranNum = Random.Range(0, GetTotalWeight());
        float counter = 0;
        
        foreach (var temp in weightDict)
        {
            counter += temp.Value;
            if (ranNum <= counter)
            {
                itemName = temp.Key;
                break;
            }
        }
        weightDict.Clear();
        return itemName;
    }
}
