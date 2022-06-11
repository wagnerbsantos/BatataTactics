using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/PrefabProvider", order = 1)]
public class PrefabProvider : ScriptableObject
{
    [SerializeField] private GameObject[] prefabList;

    public GameObject GetPrefabByIndex(int index)
    {
        return prefabList?[index];
    }

    public GameObject[] GetPrefabArray()
    {
        return prefabList;
    }

    public GameObject GetPrefabByName(string prefabName)
    {
        if (prefabList == null || prefabList?.Length <= 0)
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