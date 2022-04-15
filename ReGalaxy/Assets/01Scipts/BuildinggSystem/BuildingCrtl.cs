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
        txt.text = "�Ыΰ򥻸�T:" + "\n" + "�s��:" + buildingdatas.ID + " ����:" + buildingdatas.Lv + " ����:" + buildingdatas.Type + " �W��:" + buildingdatas.Name + " �ؿv�W��:" + buildingdatas.Format +
            " �ĪG:" + buildingdatas.Effect + "\n" + ShowDictionary(" �D��", " �ƭ�", buildingdatas.Productions) + " �ɶ����:" + buildingdatas.Time + " ���һݹq�O:" + buildingdatas.Electricity +
            " ���ѱ^���:" + buildingdatas.Jobs + "\n" + ShowDictionary(" ���ӹD��", " �ƶq", buildingdatas.ExpendItems);
        buildings.Add(txt.gameObject);

        Text txtUpgrade = Instantiate(txt_MsgObj, spawnPos).GetComponent<Text>();
        txtUpgrade.text = "�ЫΤɯŸ�T:" + "\n" + "�s��:" + buildingdatas.ID + " ����:" + buildingdatas.Lv + " ����:" + buildingdatas.Type + 
            " �W��:" + buildingdatas.Name + " �ؿv�W��:" + buildingdatas.Format + 
            "\n" + ShowDictionary(" ���ӹD��", " �ƶq", buildingdatas.ExpendItems);
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
