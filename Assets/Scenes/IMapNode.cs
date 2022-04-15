namespace Scenes
{
    public interface IMapNode
    {
        public int GetPrefabIndex();
        public string GetPrefabName();
        public bool IsWalkable();
        public bool IsFlyable();
        public bool IsSwimmable();
        public bool IsClimbable();
        public bool HasTreasure();
    }
}