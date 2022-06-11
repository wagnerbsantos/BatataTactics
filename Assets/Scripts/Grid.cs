using System;
using Scripts;
using UnityEngine;

[Serializable]
public class Grid
{
    [SerializeField]
    private Cell[] gridArray;

        
    [SerializeField]
    private int width;
    [SerializeField]
    private int length;

    public Grid(int width, int length)
    {
        gridArray = new Cell[width * length];
        this.width = width;
        this.length = length;
        InitializeArray();
    }
        
    public Grid(Cell[] gridArray)
    {
        gridArray = gridArray;
    }

    public int GetWidth()
    {
        return width;
    }
        
    public int GetLength()
    {
        return length;
    }

    private void InitializeArray()
    {
        var defaultCell = new Cell(0, 0);
        for (var x = 0; x < width; x++)
        {
            for (var z = 0; z < length; z++)
            {
                gridArray[x*width + z] = defaultCell ;
            }
        }
    }

    public Cell GetCell(int x, int z)
    {
        return gridArray[x*width + z];
    }
        
    public void SetValue(int x, int z, int nodeId, int height)
    {
        if (x >= 0 && z >= 0 && x < width && z < length)
        {
            gridArray[x*width + z] = new Cell(nodeId, height);
        }
    }
}