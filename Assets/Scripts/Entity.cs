
using System;
using UnityEngine;

public class Entity: MonoBehaviour
{
    
    private string _entityName;
    private Position _pos;

    public bool MoveTo(Position pos, Vector3 direction)
    {
        var temp = transform;
        temp.position = pos.getVector3();
        temp.rotation = Quaternion.LookRotation(direction, Vector3.up);
        _pos = pos;
        return true;
    }

    public Position GetPosition()
    {
        return _pos;
    }
}
