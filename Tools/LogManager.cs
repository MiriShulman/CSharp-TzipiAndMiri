using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Tools;


public static class LogManager
{
    const String path = "Log";

    public static String? GetPathDir()
    {
        String dirPath = path;
        int month = DateTime.Now.Month;
        string[] foldersEntries = Directory.GetDirectories(dirPath);
        foreach (string folderName in foldersEntries)
            if (folderName == month.ToString())
            {
                dirPath += folderName;
                return dirPath;
            }
        return null;
    }
    public static String? GetPathFile()
    {
        String? dirPath = GetPathDir();
        int day = DateTime.Now.Day;
        String[] filesEntries = Directory.GetFiles(dirPath);
        foreach (String fileName in filesEntries)
            if (fileName == day.ToString())
            {
                dirPath += fileName;
                return dirPath;
            }
        return null;
    }
    public static String? WriteToFile(String fileName, String funcName, String message)
    {
        String? dirPath = GetPathDir();
        String filePath;
        DirectoryInfo dir;
        FileStream file;
        if (dirPath == null)
            dir = Directory.CreateDirectory(path);
        dirPath = GetPathDir();
        if(GetPathFile() == null)
            file = File.Create(dirPath);
        filePath = GetPathFile();
        FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
        StreamWriter writer = new StreamWriter(fs);
        writer.WriteLine($"{DateTime.Now}\t{fileName}.{funcName}:\t{message}");
        return null;
    }
    
    public static void DeletePrev()
    {
        String dirPath = path;
        int month = DateTime.Now.Month;
        int month1, month2, currentMonth;
        if (month==1)
        {
            currentMonth = 1;
            month1 = 12;
            month2 = 11;
        }
        else if(month==2) 
        {
            currentMonth = 2;
            month1 = 1;
            month2 = 12;
            
        }
        else
        {
            currentMonth = month;
            month1 = month - 1;
            month2 = month-2;
        }
        string[] foldersEntries = Directory.GetDirectories(dirPath);
        foreach (string folderName in foldersEntries)
            if (folderName != currentMonth.ToString() && folderName != month1.ToString() && folderName != month2.ToString())
            {
                Directory.Delete(path+folderName);
            }
    }


}
