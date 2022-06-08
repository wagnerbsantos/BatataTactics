
using UnityEngine;

public class Position
{
    private int _x;
    private int _z;
    private int _height;
    private const float Step = 0.5f;

    public Position(int x, int z, int height)
    {
        _x = x;
        _z = z;
        _height = height;
    }

    public int getX()
    {
        return _x;
    }

    public int getZ()
    {
        return _z;
    }

    public int getHeight()
    {
        return _height;
    }

    public float getYPos()
    {
        return 1 + _height * Step;
    }

    public Vector3 getVector3()
    {
        return new Vector3(_x, getYPos(), _z);
    }
}
