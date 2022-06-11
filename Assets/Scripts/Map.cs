using System;
using UnityEngine;
using Terrain = Scripts.Terrain;

[Serializable]
public class Map
{
    [SerializeField]
    private Terrain[] nodeList;
    [SerializeField]
    private Grid grid;

    public Map(Grid grid, Terrain[] nodeList)
    {
        this.nodeList = nodeList;
        this.grid = grid;
    }

    public Terrain GetNode(int x, int z)
    {
        var cell = grid.GetCell(x, z);
        return nodeList[cell.GetNodeId()];
    }
    
    public Terrain GetNode(Position pos)
    {
        return GetNode(pos.getX(), pos.getZ());
    }
        
    public int GetHeight(int x, int z)
    {
        return grid.GetCell(x, z).GetHeight();
    }
        
    public int GetWidth()
    {
        return grid.GetWidth();
    }
        
    public int GetLength()
    {
        return grid.GetLength();
    }
}