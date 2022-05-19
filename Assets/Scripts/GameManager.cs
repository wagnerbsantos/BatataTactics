using System;
using System.Collections;
using System.Collections.Generic;
using Scenes;
using UnityEngine;
using UnityEngine.Serialization;


public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject prefabProvider;
    [SerializeField] private GameObject fieldCursorPrefab;
    [SerializeField] private GameControls gameControls;
    [SerializeField] private GameObject prefab;
    [SerializeField] private Field field;
    private IPrefabProvider _prefabProvider;
    private GameObject[,] _tileArray;
    private const float XOffset = 0f;
    private const float YOffset = 0f;
    private const float ZOffset = 0f;
    private GameObject _fieldCursor;
    private int _width;
    private int _length;

    private void Awake()
    {
        _prefabProvider = prefabProvider.GetComponent<IPrefabProvider>();
        _fieldCursor = Instantiate(fieldCursorPrefab, new Vector3(XOffset, YOffset+1, ZOffset), Quaternion.identity);
        FieldCursor fieldCursor = _fieldCursor.GetComponent<FieldCursor>();
        _width = field.getWidth();
        _length = field.getLenght();
        fieldCursor.SetMapSize(_width-1, _length-1);
        fieldCursor.SetStartingPosition(0, 0);
        _tileArray = new GameObject[_width, _length];
        gameControls.SetFieldCursor(fieldCursor);
        gameControls.SetField(field);
    }

    void Start()
    {
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _length; y++)
            {
                _tileArray[x, y] = newTile(x, 0, y, _prefabProvider.GetPrefabByIndex(field.GetNode(x, y).GetPrefabIndex()), Quaternion.identity);
            }
        }
    }

    void Update()
    {
        
    }

    GameObject newTile(int x, int y, int z,  GameObject prefab, Quaternion rotation)
    {
        return Instantiate(prefab, new Vector3(x + XOffset, y + YOffset, z + ZOffset), rotation);
    }
    
}