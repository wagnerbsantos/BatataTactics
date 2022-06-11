using System.IO;
using Scripts;
using UnityEngine;

public static class MapLoader
{
    private const string Filepath = "Assets/Data/Maps/";
    public static Map LoadMap(string mapName)
    {
        var filename = Filepath + mapName + ".json";
        if (File.Exists(filename))
        {
            var reader = new StreamReader(filename);
            var json = reader.ReadToEnd();
            var map = JsonUtility.FromJson<Map>(json);
            reader.Close();
            return map;
        }

        return null;
    }
        
    public static void SaveMap(string mapName, Map map)
    {
        var filename = Filepath + mapName + ".json";
        var writer = new StreamWriter(filename);
        var json = JsonUtility.ToJson(map, true);
        writer.Write(json);
        writer.Close();

    }
}