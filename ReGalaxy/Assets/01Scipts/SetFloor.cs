using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFloor : MonoBehaviour
{
    public List<GameObject> floors = new List<GameObject>();
    public int row, column, offset;

    private void Start()
    {
        SpawnMap(row, column);
    }

    public void SpawnMap(int row, int column)
    {
        Vector3 pos = new Vector3(-(row * offset / 2) , (column * offset / 2), 0);
        float tempX = pos.x;
        float tempY = pos.y;

        for (int i = 0; i < row; i++)
        {
            tempY = pos.y - offset;
            for (int j =  0; j < column; j++)
            {
                pos = new Vector3(pos.x = j != 0 ? pos.x + offset : tempX, tempY, 0);
                GameObject floor = Instantiate<GameObject>(floors[0],transform);
                floor.transform.localPosition = pos;
            }
        }
    }

}
