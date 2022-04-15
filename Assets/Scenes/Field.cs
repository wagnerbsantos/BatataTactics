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
            var river = new Node(1, "River");
            var mountain = new Node(2, "Mountain");
            grid.SetValue(2,0, river);
            grid.SetValue(2,1, river);
            grid.SetValue(3,1, river);
            grid.SetValue(3,2, river);
            grid.SetValue(3,3, river);
            grid.SetValue(4,3, river);
            grid.SetValue(4,4, river);
            
            grid.SetValue(3,0, mountain);
            grid.SetValue(4,0, mountain);
            grid.SetValue(4,1, mountain);
            grid.SetValue(4,2, mountain);
        }

        public int GetPrefabIndex(int x, int y)
        {
            return grid.GetNode(x, y).GetPrefabIndex();
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