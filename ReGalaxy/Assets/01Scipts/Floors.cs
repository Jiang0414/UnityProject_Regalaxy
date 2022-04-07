using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Floors : MonoBehaviour
{
    public List<Info> floors = new List<Info>();
    public Toggle isOpen1, isOpen2, isOpen3;

    public void Toggle_floors()
    {
        SetFloors();
    }

    public void SetFloors()
    {
        foreach (var floor in floors)
        {
            if (floor.range == 1)
            {
                floor.gameObject.SetActive(isOpen1.isOn);
            }
            if (floor.range == 2)
            {
                floor.gameObject.SetActive(isOpen2.isOn);
            }
            if (floor.range == 3)
            {
                floor.gameObject.SetActive(isOpen3.isOn);
            }
        }
    }
}
