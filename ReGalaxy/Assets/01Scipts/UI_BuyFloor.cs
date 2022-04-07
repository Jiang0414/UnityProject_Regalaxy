using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_BuyFloor : MonoBehaviour
{
    public int x, y;
    public Text txtFloorInfo;
    public Info floor; 

    private void Start()
    {
        txtFloorInfo = transform.Find("img_Bg").transform.Find("txt_info").GetComponent<Text>();
        txtFloorInfo.text = x.ToString() + "," + y.ToString();
    }
    private void OnEnable()
    {
        if(txtFloorInfo != null)
            txtFloorInfo.text = x.ToString() + "," + y.ToString();
    }

    public void Btn_Buy()
    {
        floor = null;
        gameObject.SetActive(false);
    }
}
