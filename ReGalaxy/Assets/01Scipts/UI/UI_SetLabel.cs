using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_SetLabel : MonoBehaviour
{
    public List<GameObject> Labels = new List<GameObject>();
    public List<GameObject> contents = new List<GameObject>();
    public Transform content;

    public void Start()
    {
        content = transform.parent.transform.Find("BackPack");
        foreach (Transform label in transform)
        {
            Labels.Add(label.gameObject);
        }
        foreach (Transform _content in content)
        {
            contents.Add(_content.gameObject);
        }
    }
    public void Btn_SwitchLabels(GameObject label)
    {
        string labelName = label.name.Replace("Label_", "");        
        foreach (var c in contents)
        {
            c.SetActive(c.name.Contains(labelName));
            if (c.name.Contains(labelName))
            {
                UI_SetBackPack uI_SetBack = content.GetComponent<UI_SetBackPack>();
                uI_SetBack.contentName = c.name;
                uI_SetBack.SetRect();
            }
        }
        foreach (var L in Labels)
        {
            L.transform.Find("img_mask").gameObject.SetActive(!L.name.Contains(labelName));
        }
    }
}
