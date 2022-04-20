using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_SetBackPack : MonoBehaviour
{
    public RectTransform content;
    public GridLayoutGroup gd_Content;
    public string contentName;
    public int height = 0;

    public void Start()
    {
        contentName = "sc_Building";        
        SetRect();
    }
    public void SetRect()
    {
        content = transform.Find(contentName).Find("Viewport").Find("Content").GetComponent<RectTransform>();
        gd_Content = content.GetComponent<GridLayoutGroup>();

        int row = (int)Mathf.Ceil(content.childCount / 3f);
        height = row * (int)gd_Content.cellSize.y + row * (int)gd_Content.spacing.y
            + gd_Content.padding.top + gd_Content.padding.bottom;


        content.sizeDelta = new Vector2(content.rect.width, height);
    }
}
