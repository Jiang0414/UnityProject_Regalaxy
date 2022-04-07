using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Info : MonoBehaviour
{
    FloorInfo floorData;
    Floors floors;
    public int x, y, range;
    private bool isBuying;
    private Image imgState;
    public Sprite stateIdle, stateSelected;
    private UI_BuyFloor windowState;
    // Start is called before the first frame update
    private void Start()
    {
        isBuying = false;
        floors = transform.parent.GetComponent<Floors>();
        windowState = transform.parent.parent.Find("FloorState").GetComponent<UI_BuyFloor>();
        imgState = transform.Find("img_block").transform.Find("img_state").GetComponent<Image>();
        range = (int)transform.GetComponent<RectTransform>().rect.width / 64;
        x = transform.localPosition.x != 0 ? (int)Math.Round(transform.localPosition.x / 64) : 0;
        y = transform.localPosition.y != 0 ? (int)Math.Round(transform.localPosition.y / 64) : 0;
        floorData = new FloorInfo(x, y, range);
        floors.floors.Add(this);
    }

    private void Update()
    {
        SetState();
    }
    private void SetState()
    {
        if (isBuying)
        {
            if(windowState.floor != this)
            {
                imgState.sprite = stateIdle;
                isBuying = false;
            }
        }
    }

    public void Btn_OpenBuyWindow()
    {
        windowState.gameObject.SetActive(false);
        isBuying = true;
        imgState.sprite = stateSelected;
        windowState.floor = this;
        windowState.x = x;
        windowState.y = y;
        windowState.transform.localPosition = transform.localPosition;
        windowState.gameObject.SetActive(true);
    }
}
