using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingCrtl : MonoBehaviour
{
    public BuildingDatas buildingdatas;
    public UpgradeDatas upgradeDatas;
    public int number;
    public Transform spawnPos;
    public GameObject txt_MsgObj;
    public List<GameObject> buildings = new List<GameObject>();
    private void Start()
    {
        R_Buildings.Instance.GetProductions(number);
        R_Buildings.Instance.GetExpenditems(number);
        buildingdatas = new BuildingDatas(number, R_Buildings.Instance.GetBuildLv(number), R_Buildings.Instance.GetBuildType(number),
            R_Buildings.Instance.GetBuildName(number), R_Buildings.Instance.GetBuildFormat(number), R_Buildings.Instance.GetBuildEffect(number),
            R_Buildings.productions, R_Buildings.Instance.GetBuildTime(number), R_Buildings.Instance.GetBuildElectricity(number),
            R_Buildings.Instance.GetBuildJobs(number), R_Buildings.expenditems);

        upgradeDatas = new UpgradeDatas(number, R_Upgrades.Instance.GetBuildLv(number), R_Upgrades.Instance.GetBuildType(number),
            R_Upgrades.Instance.GetBuildName(number), R_Upgrades.Instance.GetBuildFormat(number), R_Upgrades.expenditems); ;

        Text txt = Instantiate(txt_MsgObj, spawnPos).GetComponent<Text>();
        txt.text = "房屋基本資訊:" + "\n" + "編號:" + buildingdatas.ID + " 等級:" + buildingdatas.Lv + " 種類:" + buildingdatas.Type + " 名稱:" + buildingdatas.Name + " 建築規格:" + buildingdatas.Format +
            " 效果:" + buildingdatas.Effect + "\n" + ShowDictionary(" 道具", " 數值", buildingdatas.Productions) + " 時間單位:" + buildingdatas.Time + " 單位所需電力:" + buildingdatas.Electricity +
            " 提供崗位數:" + buildingdatas.Jobs + "\n" + ShowDictionary(" 消耗道具", " 數量", buildingdatas.ExpendItems);
        buildings.Add(txt.gameObject);

        Text txtUpgrade = Instantiate(txt_MsgObj, spawnPos).GetComponent<Text>();
        txtUpgrade.text = "房屋升級資訊:" + "\n" + "編號:" + buildingdatas.ID + " 等級:" + buildingdatas.Lv + " 種類:" + buildingdatas.Type + 
            " 名稱:" + buildingdatas.Name + " 建築規格:" + buildingdatas.Format + 
            "\n" + ShowDictionary(" 消耗道具", " 數量", buildingdatas.ExpendItems);
        buildings.Add(txtUpgrade.gameObject);
    }

    private string ShowDictionary(string title, string amount, Dictionary<string,string> D)
    {
        string msg = "";
        int count = 1;
        foreach(var content in D)
        {
            msg += title+ count+":" + content.Key + amount + count + ":" + content.Value;
            count += 1;
        }
        return msg;
    }
}
