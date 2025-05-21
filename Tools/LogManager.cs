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

    //public static String? GetPathDir()
    //{
    //    String dirPath = path;
    //    int month = DateTime.Now.Month;
    //    string[] foldersEntries = Directory.GetDirectories(dirPath);
    //    foreach (string folderName in foldersEntries)
    //        if (folderName == month.ToString())
    //        {
    //            dirPath += folderName;
    //            return dirPath;
    //        }
    //    return null;
    //}
    //public static String? GetPathFile()
    //{
    //    String? dirPath = GetPathDir();
    //    int day = DateTime.Now.Day;
    //    String[] filesEntries = Directory.GetFiles(dirPath);
    //    foreach (String fileName in filesEntries)
    //        if (fileName == day.ToString())
    //        {
    //            dirPath += fileName;
    //            return dirPath;
    //        }
    //    return null;
    //}
    //public static String? WriteToLog(String fileName, String funcName, String message)
    //{
    //    String? dirPath = GetPathDir();
    //    String filePath;
    //    DirectoryInfo dir;
    //    FileStream file;
    //    if (dirPath == null)
    //        dir = Directory.CreateDirectory(path);
    //    dirPath = GetPathDir();
    //    if(GetPathFile() == null)
    //        file = File.Create(dirPath);
    //    filePath = GetPathFile();
    //    FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
    //    StreamWriter writer = new StreamWriter(fs);
    //    writer.WriteLine($"{DateTime.Now}\t{fileName}.{funcName}:\t{message}");
    //    return null;
    //}

    //public static void DeletePrev()
    //{
    //    String dirPath = path;
    //    int month = DateTime.Now.Month;
    //    int month1, month2, currentMonth;
    //    if (month==1)
    //    {
    //        currentMonth = 1;
    //        month1 = 12;
    //        month2 = 11;
    //    }
    //    else if(month==2) 
    //    {
    //        currentMonth = 2;
    //        month1 = 1;
    //        month2 = 12;

    //    }
    //    else
    //    {
    //        currentMonth = month;
    //        month1 = month - 1;
    //        month2 = month-2;
    //    }
    //    string[] foldersEntries = Directory.GetDirectories(dirPath);
    //    foreach (string folderName in foldersEntries)
    //        if (folderName != currentMonth.ToString() && folderName != month1.ToString() && folderName != month2.ToString())
    //        {
    //            Directory.Delete(path+folderName);
    //        }
    //}

    public static string PathLog()
    {
        return $@"{Directory.GetParent(Directory.GetCurrentDirectory()).FullName}/bin/{path}";
    }
    public static string CurrentPathFolder()
    {
        return PathLog() + "//" + DateTime.Now.ToString("MM-yyyy");
    }
    public static string CurrentPathFile()
    {
        return $@"{CurrentPathFolder()}/{DateTime.Now.Day}.log";
    }
    public static void WriteToLog(string project, string func, string message)
    {
        if (!Directory.Exists(CurrentPathFolder()))
        {
            Directory.CreateDirectory(CurrentPathFolder());
        }
        if (!File.Exists(CurrentPathFile()))
        {
            File.Create(CurrentPathFile()).Close();
        }
        using (StreamWriter writer = new StreamWriter(CurrentPathFile(), true))
        {
            writer.WriteLine($"{DateTime.Now}\t{project}.{func}:\t{message}\n");
        }
    }

    public static void DeleteLog()
    {
        DirectoryInfo dir = new DirectoryInfo(PathLog());
        DateTime date = DateTime.Now.AddMonths(-2);
        foreach (DirectoryInfo d in dir.GetDirectories())
        {
            if (DateTime.Parse(d.Name) < date)
                d.Delete(true);
        }
    }


}
