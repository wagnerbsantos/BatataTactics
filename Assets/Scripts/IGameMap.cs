using System.Collections.Generic;

namespace Scenes
{
    public interface IGameMap
    {
        public IMapNode[,] GetMap();

        public IEnumerable<IMapNode> GetNextNode(out int x, out int y, out int z);

        public IMapNode GetNodeByIndex(int x, int y, int z);

        public float GetXScale();
        public float GetYScale();
        public float GetZScale();

    }
}