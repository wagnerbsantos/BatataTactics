using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldCursor : MonoBehaviour
{
    private int _x, _z;
    private int _xSize, _zSize;
    public void MoveNorth()
    {
        if (_z >= _zSize)
            return;
        _z += 1;
        transform.position += Vector3.forward;
    }
    
    public void MoveSouth()
    {
        if (_z <= 0)
            return;
        _z -= 1;
        transform.position += Vector3.back;
    }
    
    public void MoveWest()
    {
        if (_x <= 0)
            return;
        _x -= 1;
        transform.position += Vector3.left;
    }
    
    public void MoveEast()
    {
        if (_x >= _xSize)
            return;
        _x += 1;
        transform.position += Vector3.right;
    }

    public void SetStartingPosition(int x, int z)
    {
        _x = x;
        _z = z;
    }

    public void SetMapSize(int x, int z)
    {
        _xSize = x;
        _zSize = z;
    }

    public int getXPos()
    {
        return _x;
    }

    public int getZPos()
    {
        return _z;
    }
}
