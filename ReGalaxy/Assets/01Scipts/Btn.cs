using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn : MonoBehaviour
{
    public GameObject txt_MsgObj;
    public Transform spawnPos;
    public List<GameObject> items = new List<GameObject>();

    public void BtnGetItem()
    {
        Random.seed = (int)(Random.value * Random.Range(0, 1000));
        int RanCombin = Random.Range(1, 13);

        string itemNumber = GetRandom.Instance.GetRandomValue(1, R_ItemCombin.Instance.GetItemType1(RanCombin));
        int itemAmount = int.Parse(GetRandom.Instance.GetRandomValue(1, R_ItemCombin.Instance.GetItemAmount1(RanCombin)));

        Text txt = Instantiate(txt_MsgObj, spawnPos).GetComponent<Text>();
        txt.text = "獲得第" + RanCombin + "組" + R_ItemCombin.Instance.GetItemName(RanCombin) + "的"
            + R_Item.Instance.GetItemName(R_Item.Instance.GetItemID(itemNumber)) + itemAmount + "個";
        items.Add(txt.gameObject);
    }

    public void BtnGetItemAll()
    {
        Random.seed = (int)(Random.value * Random.Range(0, 1000));
        int RanCombin = Random.Range(1, 13);
        R_ItemCombin.Instance.GetItemTypes(RanCombin);
        foreach (var item in R_ItemCombin.combineTypes)
        {
            string itemNumber = GetRandom.Instance.GetRandomValue(1, item.Key);
            int itemAmount = int.Parse(GetRandom.Instance.GetRandomValue(1, item.Value));

            Text txt = Instantiate(txt_MsgObj, spawnPos).GetComponent<Text>();
            txt.text = "獲得第" + RanCombin + "組" + R_ItemCombin.Instance.GetItemName(RanCombin) + "的"
                + R_Item.Instance.GetItemName(R_Item.Instance.GetItemID(itemNumber)) + itemAmount + "個";
            items.Add(txt.gameObject);
        }
        R_ItemCombin.combineTypes.Clear();
    }

    public void BtnClearItem()
    {
        foreach (var item in items)
        {
            Destroy(item);
        }
        items.Clear();
    }
}
