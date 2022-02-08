// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Francois.Lannoy.FeatureMatching;

    static string GetExecutingPath(string path)
    {
        var executingAssemblyPath =
            Assembly.GetExecutingAssembly().Location;
        var executingPath = Path.GetDirectoryName(executingAssemblyPath);
        return path;
    }
    var executingPath = GetExecutingPath(args[0]);
    var imageScenesData = new List<byte[]>();
    foreach (var imagePath in
        Directory.EnumerateFiles(Path.Combine(executingPath, args[1])))
    {
        var imageBytes = await File.ReadAllBytesAsync(imagePath);
        imageScenesData.Add(imageBytes);
    }
    Console.WriteLine("Hello, World!");
