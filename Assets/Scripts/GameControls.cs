using System;
using UnityEngine;

namespace Scenes
{
    public class GameControls : MonoBehaviour
    {
        private FieldCursor _controlledFieldCursor;
        private Field _field;

        public void SetFieldCursor(FieldCursor ch)
        {
            _controlledFieldCursor = ch;
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
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                int x = _controlledFieldCursor.getXPos();
                int z = _controlledFieldCursor.getZPos();
                Debug.Log(_field.GetNode(x, z).IsSwimmable());
            }
        }
    }
}