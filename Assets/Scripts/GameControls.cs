using UnityEngine;

public class GameControls : MonoBehaviour
{
    private FieldCursor _controlledFieldCursor;
    private CharCamera _charCamera;
    private Entity _player;
    private Map _map;
    private Entity _selected = null;

    public void SetFieldCursor(FieldCursor ch)
    {
        _controlledFieldCursor = ch;
    }

    public void SetPlayer(Entity player)
    {
        _player = player;
    }

    public void SetCharCamera(CharCamera cam)
    {
        _charCamera = cam;
    }

    public void SetField(Map map)
    {
        _map = map;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _controlledFieldCursor.MoveNorth();
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            _controlledFieldCursor.MoveWest();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            _controlledFieldCursor.MoveSouth();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _controlledFieldCursor.MoveEast();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            _charCamera.ZoomUp();
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            _charCamera.ZoomDown();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            var clickPos = _controlledFieldCursor.GetPosition();
            if (_selected == null && clickPos.getX() == _player.GetPosition().getX() && clickPos.getZ() == _player.GetPosition().getZ())
                _selected = _player;
            else if (_selected != null)
            {
                if (_map.GetNode(clickPos).IsWalkable())
                {
                    //TODO and not occupied.
                    //In range
                    _selected.MoveTo(clickPos, Vector3.forward);
                }
                
                _selected = null;
            }
        }
        _charCamera.SetFocus(_controlledFieldCursor.transform);
    }
}