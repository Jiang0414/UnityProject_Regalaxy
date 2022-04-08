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
                floor.toggleMask.SetActive(!isOpen1.isOn);
            }
            if (floor.range == 2)
            {
                floor.toggleMask.SetActive(!isOpen2.isOn);
            }
            if (floor.range == 3)
            {
                floor.toggleMask.SetActive(!isOpen3.isOn);
            }
        }
        CheckToggle();
    }
    public void CheckToggle()
    {
        if ((!isOpen1.isOn && !isOpen2.isOn && !isOpen3.isOn) || (isOpen1.isOn && isOpen2.isOn && isOpen3.isOn))
        {
            foreach (var floor in floors)
            {
                floor.toggleMask.SetActive(false);
            }
            return;
        }
    }
}
