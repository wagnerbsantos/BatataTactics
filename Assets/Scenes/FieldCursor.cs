using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldCursor : MonoBehaviour
{
    public void MoveNorth()
    {
        transform.position += Vector3.forward;
    }
    
    public void MoveSouth()
    {
        transform.position += Vector3.back;
    }
    
    public void MoveWest()
    {
        transform.position += Vector3.left;
    }
    
    public void MoveEast()
    {
        transform.position += Vector3.right;
    }
}
