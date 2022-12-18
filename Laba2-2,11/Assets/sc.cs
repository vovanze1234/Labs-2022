using Microsoft.Cci;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class sc : MonoBehaviour
{
    public string dirName;
    public string filename = "Test";
    public string result ;
    public string text;
    public string[] words;
    public string nenado;
    public string[] nenado1;
    public void ButClick3()
    {
        string[] allfiles = Directory.GetFiles(dirName);
        Debug.Log("Все файлы сохраненны");
        Console.ReadLine();
    }
    public void ButClick4()
    {
        DirectoryInfo allfolders = new DirectoryInfo(dirName);
        DirectoryInfo[] folders = allfolders.GetDirectories();
        Debug.Log("Все папки сохранены");
        Console.ReadLine();
    }
    public void ButClick()
    {
        string[] allfiles = Directory.GetFiles(dirName);
        foreach (string filename in allfiles)
        {
            
            result += $" {(Path.GetFileName(filename))}";
        }
        Console.ReadLine();
    }
    public void ButClick2()
    {
        DirectoryInfo allfolders = new DirectoryInfo(dirName);
        DirectoryInfo[] folders = allfolders.GetDirectories();
        foreach (DirectoryInfo foldername in folders)
        {
            
            result += $" {foldername.Name}";
            
        }
        Debug.Log(result);
        Console.ReadLine();
    }
    public void metod_2()
    {
        string path = @"C:\Users\vovan\Documents\Laba_unity\inspisok\" + filename + ".txt";
        var file = File.Open(path, FileMode.OpenOrCreate, FileAccess.Write);
        using (StreamWriter sw = new StreamWriter(file))
        sw.Write(result);
        
        
    }
    public void metod_3()
    {
        string path = @"C:\Users\vovan\Documents\Laba_unity\inspisok\" + filename + ".txt";
        var file = File.Open(path, FileMode.OpenOrCreate, FileAccess.Read);
        using (StreamReader sr = new StreamReader(file))
        text = sr.ReadLine();
        words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            
        }

    }
    public void metod_4()
    {
        
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == nenado)
            {
                words[i].Remove(words[i].Length);
            }
            string path = @"C:\Users\vovan\Documents\Laba_unity\inspisok\" + words[i];
            var file = File.Open(path, FileMode.OpenOrCreate, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(file));
        }
        
    }

}