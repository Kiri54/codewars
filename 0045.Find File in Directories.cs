/*https://www.codewars.com/kata/56b089fd747d2a2a1c000021

Item, File and Folder classes are preloaded, and you can see the code here:

public abstract class Item
    {
        public string Name { get; set; }
    }

public class File : Item
    {
        public File(string name)
        {
            Name = name;
        }
    }

public class Folder : Item
    {
        public Folder(string name, List<Item> items)
        {
            Name = name;
            Items = items;
        }
        public List<Item> Items { get; set; }
    }
So, files have only names, and folders have name and a list of folders and files.

Your task is to get the folder and file's name and return the address of the file.

public static string FindFileInFolder(Folder folder, String fileName)
You can suppose the file always exists and there is only one file with this name.

Example:

Folder myFolder = new Folder("All",
                new List<Item>()
                {
                    new File("readme"),
                    new File("question"),
                    new Folder("Docs",
                        new List<Item>()
                        {
                            new File("info"),
                            new File("answer")
                        })
                });
Then

FindFileInFolder(myFolder, "answer")
must return
All\Docs\answer*/

using System;
using System.Collections.Generic;

public class Search
{
    public static string FindFileInFolder(Folder folder, String fileName)
    {
        foreach (Item item in folder.Items)
        {
            if (item is File)
            {
                if (item.Name==fileName)
                {
                    return folder.Name + "\\" + fileName;
                }
            }
            else
            {
                string s = FindFileInFolder((Folder)item, fileName);
                if(s!="")
                {
                    return folder.Name + "\\" + s;
                }
            }
        }
        return ""; 
    }
}