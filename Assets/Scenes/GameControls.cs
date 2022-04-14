using System;
using UnityEngine;

namespace Scenes
{
    public class GameControls : MonoBehaviour
    {
        private FieldCursor _controlledFieldCursor;

        public void SetControlledCharacter(FieldCursor ch)
        {
            _controlledFieldCursor = ch;
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
        }
    }
}