using UnityEngine;

namespace Scenes
{
    public class Grid
    {
        private int _width;
        private int _length;
        private Node[,] _gridArray;

        public Grid(int width, int length)
        {
            _width = width;
            _length = length;

            _gridArray = new Node[width, length];
            InitializeArray();
        }

        private void InitializeArray()
        {
            for (var x = 0; x < _width; x++)
            {
                for (var y = 0; y < _length; y++)
                {
                    _gridArray[x, y] = new Node(0, "Default");
                }
            }
        }

        public Grid(Node[,] nodeArray)
        {
            _width = nodeArray.GetLength(0);
            _length = nodeArray.GetLength(1);
            _gridArray = nodeArray;
        }

        private Vector3 GetWorldPosition(int x, int y, float cellSize = 1)
        {
            return new Vector3(x , 0, y) * cellSize;
        }

        public Node GetNode(int x, int y)
        {
            return _gridArray[x, y];
        }

        private void GetXY(Vector3 worldPosition, out int x, out int y, float cellsize = 1)
        {
            x = Mathf.FloorToInt(worldPosition.x / cellsize);
            y = Mathf.FloorToInt(worldPosition.z / cellsize)+1;
        }

        public void SetValue(int x, int y, Node node)
        {
            if (x >= 0 && y >= 0 && x < _width && y < _length)
            {
                _gridArray[x, y] = node;
            }
        }

        public void SetValue(Vector3 worldPosition, Node node)
        {
            GetXY(worldPosition, out var x, out var y);
            SetValue(x, y, node);
        }
        
        
        
    }
}