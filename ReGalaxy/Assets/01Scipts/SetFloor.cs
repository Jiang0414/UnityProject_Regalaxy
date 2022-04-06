using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFloor : MonoBehaviour
{
    public List<GameObject> floors = new List<GameObject>();
    private GameObject[,] blocks;
    private List<GameObject> blockClear = new List<GameObject>();
    private bool canChage;
    private int x, y;
    public int row, column, offset;
    public int block2, block3;
    [Range(0, 1)]
    public float minusRow, minusColum;

    public bool isdestory;
    private void Start()
    {
        SpawnMap(row, column);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            ChangeBlock(block2, 2);
        }
    }

    private void SpawnMap(int row, int column)
    {
        blocks = new GameObject[row, column];
        Vector3 pos = new Vector3(-(row * offset / 2), (column * offset / 2), 0);
        float tempX = pos.x;
        float tempY = pos.y;

        for (int i = 0; i < column; i++)
        {
            tempY = pos.y - offset;
            for (int j = 0; j < row; j++)
            {
                pos = new Vector3(pos.x = j != 0 ? pos.x + offset : tempX, tempY, 0);
                GameObject floor = Instantiate<GameObject>(floors[0], transform);
                floor.name = floor.name.Replace("(Clone)", "");
                floor.transform.localPosition = pos;
                blocks[j, i] = floor;
            }
        }
        MinusBlock(row, column, minusRow, minusColum);
    }

    private void MinusBlock(int row, int column, float minusRow, float minusColum)
    {
        int minusRange_c = (int)((column / 2) * minusColum);
        int minusRange_r = (int)((row / 2) * minusRow);

        for (int i = 0; i < row; i++) //¤W
        {
            int minusValue = Random.Range(0, minusRange_c);
            for (int j = 0; j < minusValue; j++)
            {
                if (blocks[i, j] != null)
                    Destroy(blocks[i, j].gameObject);
            }
        }
        for (int i = 0; i < row; i++) //¤U
        {
            int minusValue = Random.Range(column - 1, column - 1 - minusRange_c);
            for (int j = column - 1; j > minusValue; j--)
            {
                if (blocks[i, j] != null)
                    Destroy(blocks[i, j].gameObject);
            }
        }
        for (int i = 0; i < column; i++) //¥ª
        {
            int minusValue = Random.Range(0, minusRange_r);
            for (int j = 0; j < minusValue; j++)
            {
                if (blocks[i, j] != null)
                    Destroy(blocks[j, i].gameObject);
            }
        }
        for (int i = 0; i < column; i++) //¥k
        {
            int minusValue = Random.Range(row - 1, row - 1 - minusRange_r);
            for (int j = row - 1; j > minusValue; j--)
            {
                if (blocks[i, j] != null)
                    Destroy(blocks[j, i].gameObject);
            }
        }
        ClearSingle();
        ChangeBlock(block2, 2);
    }
    private bool IsAlone(int x, int y)
    {
        int neighbor = 0;
        if (blocks[x, y] != null)
        {
            int tempX, tempY;
            if (blocks[tempX = x + 1 > row - 1 ? row - 1 : x + 1, y] != null)
            {
                neighbor += 1;
            }
            if (blocks[tempX = x - 1 < 0 ? 0 : x - 1, y] != null)
            {
                neighbor += 1;
            }
            if (blocks[x, tempY = y + 1 > column - 1 ? column - 1 : y + 1] != null)
            {
                neighbor += 1;
            }
            if (blocks[x, tempY = y - 1 < 0 ? 0 : column - 1] != null)
            {
                neighbor += 1;
            }
        }
        return neighbor < 3;
    }
    private void GetSingle()
    {
        for (int i = 0; i < column; i++)
        {
            for (int j = 0; j < row; j++)
            {
                if (blocks[i, j] != null && IsAlone(i, j))
                {
                    blockClear.Add(blocks[i, j]);
                }
            }
        }
    }
    private void ClearSingle()
    {
        GetSingle();
        foreach (var block in blockClear)
        {
            Destroy(block);
        }
        blockClear.Clear();
    }

    private void ChangeBlock(int blockNumber, int length)
    {
        int number = blockNumber;
        Debug.Log(number);
        /*int x = Random.Range(0, row);
        int y = Random.Range(0, column);
        if (CanChangeBlock(x, y, 2))
        {
            Chageblock(x, y, 2, floors[1]);
            number -= 1;
        }*/
        while (number > 0)
        {
            SetIndex();

            x = x + length > row ? row - length : x;
            y = y + length > column ? column - length : y;
            CanChangeBlock(x, y, 2);
            if (canChage)
            {
                Chageblock(x, y, 2, floors[1]);
                number -= 1;
            }
        }
    }
    private void SetIndex()
    {
        x = Random.Range(0, row);
        y = Random.Range(0, column);
        if (blocks[x, y] == null || blocks[x, y].name == floors[1].name || blocks[x, y].name == floors[2].name)
        {
            SetIndex();
        }
    }
    private void CanChangeBlock(int x, int y, int length)
    {
        int tempx = x + length > row ? row : x + length;
        int tempy = y + length > column ? column : y + length;
        for (int i = y; i < tempy; i++)
        {
            for (int j = x; j < tempx; j++)
            {
                if (blocks[j, i] == null || blocks[j, i].name == floors[1].name || blocks[j, i].name == floors[2].name)
                {
                    canChage = false;
                    break;
                }
                else if (blocks[j, i] != null && blocks[j, i].name == floors[0].name)
                {
                    canChage = true;
                }
            }
        }
    }
    private void Chageblock(int x, int y, int length, GameObject block)
    {
        int tempx = x + length > row ? row : x + length;
        int tempy = y + length > column ? column : y + length;
        double _offset = System.Math.Ceiling((double)(length / 2) * (offset / 2));
        Vector3 center = new Vector3(blocks[x, y].transform.localPosition.x + (float)_offset, blocks[x, y].transform.localPosition.y - (float)_offset, 0);
        GameObject _block = Instantiate<GameObject>(block, transform);
        _block.name = _block.name.Replace("(Clone)", "");
        _block.transform.localPosition = center;
        for (int i = y; i < tempy; i++)
        {
            for (int j = x; j < tempx; j++)
            {
                if (blocks[j, i] != null)
                    Destroy(blocks[j, i]);
                blocks[j, i] = _block;
            }
        }
    }
}
