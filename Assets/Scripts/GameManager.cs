using Scripts;
using UnityEngine;
using Terrain = Scripts.Terrain;

public class GameManager : MonoBehaviour
{
    public PrefabProvider terrainProvider;
    public PrefabProvider entityProvider;
    [SerializeField] private GameObject fieldCursorPrefab;
    [SerializeField] private GameControls gameControls;
    [SerializeField] private GameObject cameraPrefab;
    private Map _map;
    private GameObject[,] _tileArray;
    private CharCamera _camera;
    private const float XOffset = 0f;
    private const float YOffset = 0f;
    private const float ZOffset = 0f;
    private GameObject _fieldCursor;
    private int _width;
    private int _length;

    private void Awake()
    {
        var player =
            Instantiate(entityProvider.GetPrefabByIndex(0), new Position(1, 1, 0).getVector3(), Quaternion.identity)
                .GetComponent<Entity>();
        player.MoveTo(new Position(2, 2, 0), Vector3.forward);
        _map = GenerateData();
        _fieldCursor = Instantiate(fieldCursorPrefab, new Vector3(XOffset, YOffset + 1, ZOffset),
            Quaternion.identity);
        _camera = Instantiate(cameraPrefab, new Vector3(), Quaternion.identity).GetComponent<CharCamera>();
        FieldCursor fieldCursor = _fieldCursor.GetComponent<FieldCursor>();
        _width = _map.GetWidth();
        _length = _map.GetLength();
        fieldCursor.SetMapSize(_width - 1, _length - 1);
        fieldCursor.SetStartingPosition(0, 0);
        _tileArray = new GameObject[_width, _length];
        gameControls.SetFieldCursor(fieldCursor);
        gameControls.SetPlayer(player);
        gameControls.SetCharCamera(_camera);
        gameControls.SetField(_map);
    }

    void Start()
    {
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _length; y++)
            {
                _tileArray[x, y] = newTile(x, 0, y,
                    terrainProvider.GetPrefabByIndex(_map.GetNode(x, y).GetPrefabIndex()), Quaternion.identity);
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F11))
        {
            //_controlledFieldCursor.MoveNorth();
        }
    }

    GameObject newTile(int x, int y, int z, GameObject prefab, Quaternion rotation)
    {
        return Instantiate(prefab, new Vector3(x + XOffset, y + YOffset, z + ZOffset), rotation);
    }

    private Map GenerateData()
    {
        var map = MapLoader.LoadMap("mapa 1");
        if (map != null)
        {
            return map;
        }
        var terrainList = new Terrain[4];
        terrainList[0] = new Terrain(0, "Default");
        terrainList[1] = new Terrain(1, "Grass", true, true, false, false, null);
        terrainList[2] = new Terrain(2, "River", false, true, false, false, null);
        terrainList[3] = new Terrain(3, "Mountain", true, false, false, false, null);
        var grid = new Grid(5, 5);
        grid.SetValue(0, 0, 1, 0);
        grid.SetValue(0, 1, 1, 0);
        grid.SetValue(0, 2, 1, 0);
        grid.SetValue(0, 3, 1, 0);
        grid.SetValue(0, 4, 1, 0);
        grid.SetValue(1, 0, 1, 0);
        grid.SetValue(1, 1, 1, 0);
        grid.SetValue(1, 2, 1, 0);
        grid.SetValue(1, 3, 1, 0);
        grid.SetValue(1, 4, 1, 0);
        grid.SetValue(2, 0, 2, 0);
        grid.SetValue(2, 1, 2, 0);
        grid.SetValue(2, 2, 2, 0);
        grid.SetValue(2, 3, 1, 0);
        grid.SetValue(2, 4, 1, 0);
        grid.SetValue(3, 0, 3, 0);
        grid.SetValue(3, 1, 3, 0);
        grid.SetValue(3, 2, 2, 0);
        grid.SetValue(3, 3, 2, 0);
        grid.SetValue(3, 4, 1, 0);
        grid.SetValue(4, 0, 3, 0);
        grid.SetValue(4, 1, 3, 0);
        grid.SetValue(4, 2, 3, 0);
        grid.SetValue(4, 3, 2, 0);
        grid.SetValue(4, 4, 1, 0);
        map = new Map(grid, terrainList);
        MapLoader.SaveMap("mapa 1", map);
        return map;
    }

}