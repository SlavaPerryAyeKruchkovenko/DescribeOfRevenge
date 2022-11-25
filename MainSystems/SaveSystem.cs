using System.Reflection;
using System.Net.Mime;
using System.IO;
using System;
using Godot;
using Directory = System.IO.Directory;
using File = System.IO.File;
using Path = System.IO.Path;
using System.Text.Json;

public class SaveSystem : Godot.Object
{
    public DirectoryInfo SaveDirectory => Directory.CreateDirectory(SavePath);

    public string SavePath { get; } = Path.Combine(
        Assembly.GetExecutingAssembly().Location,
        "Saves");

    public void SaveObject<T>(T obj, string fileName)
    {
        var filePath = Path.Combine(SavePath, fileName);
        var json = JsonSerializer.Serialize(obj);

        if (File.Exists(filePath)) throw new ArgumentException("File already exists", nameof(fileName));
        File.WriteAllText(filePath, json);
    }

    public T LoadObject<T>(string fileName)
    {
        var filePath = Path.Combine(SavePath, fileName);
        var json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<T>(json);
    }
}
