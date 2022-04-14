using UnityEngine;

namespace Scenes
{
    public class Field : MonoBehaviour
    {
        Grid grid;
        [SerializeField] int width = 5;
        [SerializeField] int length = 5;
        [SerializeField] float cellSize = 1f;
        private Vector3 _position;
        private void Awake()
        {
            grid = new Grid(width, length);
            _position = transform.position;
            grid.SetValue(2,0, new Node(true, 1));
            grid.SetValue(2,1, new Node(true, 1));
            grid.SetValue(3,1, new Node(true, 1));
            grid.SetValue(3,2, new Node(true, 1));
            grid.SetValue(3,3, new Node(true, 1));
            grid.SetValue(4,3, new Node(true, 1));
            grid.SetValue(4,4, new Node(true, 1));
            
            grid.SetValue(3,0, new Node(true, 2));
            grid.SetValue(4,0, new Node(true, 2));
            grid.SetValue(4,1, new Node(true, 2));
            grid.SetValue(4,2, new Node(true, 2));
        }

        public int GetPrefabIndex(int x, int y)
        {
            return grid.GetNode(x, y).value;
        }

        private void Update()
        {

        }

        public int getWidth()
        {
            return width;
        }

        public int getLenght()
        {
            return length;
        }
    }

}