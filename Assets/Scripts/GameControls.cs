using System;
using UnityEngine;

namespace Scenes
{
    public class GameControls : MonoBehaviour
    {
        private FieldCursor _controlledFieldCursor;
        private CharCamera _charCamera;
        private Entity _player;
        private Field _field;
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
        

        public void SetField(Field field)
        {
            _field = field;
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
                Position clickPos = _controlledFieldCursor.GetPosition();
                if (_selected == null && clickPos.getX() == _player.getPosition().getX() && clickPos.getZ() == _player.getPosition().getZ())
                    _selected = _player;
                else if (_selected != null)
                {
                    _selected.MoveTo(clickPos, Vector3.forward);
                    _selected = null;
                }
                //Debug.Log(_field.GetNode(x, z).IsSwimmable());
            }
            _charCamera.SetFocus(_controlledFieldCursor.transform);
        }
    }
}