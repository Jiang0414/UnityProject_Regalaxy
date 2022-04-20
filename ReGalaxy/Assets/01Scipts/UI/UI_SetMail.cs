using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_SetMail : MonoBehaviour
{
    public RectTransform content;
    public VerticalLayoutGroup gd_Content;
    public string contentName;
    public int height = 0;

    public void Start()
    {
        contentName = "sc_system";
        SetRect();
    }
    public void SetRect()
    {
        content = transform.Find(contentName).Find("Viewport").Find("Content").GetComponent<RectTransform>();
        gd_Content = content.GetComponent<VerticalLayoutGroup>();

        int row = content.childCount;
        int contentHeigh = row > 1 ? (int)content.GetChild(0).GetComponent<RectTransform>().rect.height : 0;
        height = row * contentHeigh + row * (int)gd_Content.spacing
            + gd_Content.padding.top + gd_Content.padding.bottom;


        content.sizeDelta = new Vector2(content.rect.width, height);
    }
}
