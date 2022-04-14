using UnityEngine;

namespace Scenes
{
    public class Grid
    {
        private int width;
        private int length;
        private Node[,] gridArray;

        public Grid(int width, int length)
        {
            this.width = width;
            this.length = length;

            gridArray = new Node[width, length];
            draw();
        }

        public void draw()
        {
            for (var x = 0; x < width; x++)
            {
                for (var y = 0; y < length; y++)
                {
                    gridArray[x, y] = new Node(true, 3);
                }
            }
        }

        public Grid(Node[,] nodeArray)
        {
            this.width = nodeArray.GetLength(0);
            this.length = nodeArray.GetLength(1);
            gridArray = nodeArray;
            draw();
        }

        private Vector3 GetWorldPosition(int x, int y, float cellSize = 1)
        {
            return new Vector3(x , 0, y) * cellSize;
        }

        public Node GetNode(int x, int y)
        {
            return gridArray[x, y];
        }

        private void GetXY(Vector3 worldPosition, out int x, out int y, float cellsize = 1)
        {
            x = Mathf.FloorToInt(worldPosition.x / cellsize);
            y = Mathf.FloorToInt(worldPosition.z / cellsize)+1;
        }

        public void SetValue(int x, int y, Node node)
        {
            if (x >= 0 && y >= 0 && x < width && y < length)
            {
                gridArray[x, y] = node;
            }
        }

        public void SetValue(Vector3 worldPosition, Node node)
        {
            GetXY(worldPosition, out var x, out var y);
            SetValue(x, y, node);
        }
        
        
        
    }
}