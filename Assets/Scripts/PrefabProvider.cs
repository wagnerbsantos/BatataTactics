using System;
using System.Collections.Generic;
using UnityEngine;

namespace Scenes
{
    public class PrefabProvider : MonoBehaviour, IPrefabProvider
    {
        [SerializeField] private GameObject[] prefabList;

        public GameObject GetPrefabByIndex(int index)
        {
            if (prefabList == null)
                return null;
            return prefabList[index];
        }

        public GameObject[] GetPrefabArray()
        {
            if (prefabList == null)
                return null;
            return prefabList;
        }

        public GameObject GetPrefabByName(string prefabName)
        {
            if (prefabList == null)
                return null;
            foreach (var prefab in prefabList)
            {
                if (prefab.name == prefabName)
                    return prefab;
            }

            return prefabList[0];
        }

        public string[] GetPrefabNameArray()
        {
            var nameList = new string[prefabList.Length];
            for (var i = 0; i < prefabList.Length; i++)
            {
                nameList[i] = prefabList[i].name;
            }

            return nameList;
        }
    }
}