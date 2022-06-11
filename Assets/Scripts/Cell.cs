using System;
using UnityEngine;

[Serializable]
public class Cell
{
    [SerializeField]
    private int terrainId;
    [SerializeField]
    private int height;

    public Cell(int terrainId, int height)
    {
        this.terrainId = terrainId;
        this.height = height;
    }

    public int GetNodeId()
    {
        return terrainId;
    }
        
    public int GetHeight()
    {
        return height;
    }
}