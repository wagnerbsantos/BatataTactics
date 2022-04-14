using UnityEngine;

namespace Scenes
{
    public interface IPrefabProvider
    {
        public GameObject GetPrefabByIndex(int index);
        public GameObject[] GetPrefabArray();
        public GameObject GetPrefabByName(string prefabName);
        public string[] GetPrefabNameArray();
    }
}