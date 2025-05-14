namespace Tools;
static public class LogManager
{
     private const string log_Path = "Log";
    public static string GetThisDir()
    {
        string path=$@"{log_Path}\{DateTime.Now.Year}.{DateTime.Now.Month}";
        if (Directory.Exists(path))
            Directory.CreateDirectory(path);
        return path;
    }
    public static string GetThisfile()
    {
        string path = $@"{GetThisDir()}\{DateTime.Now.Year}.{DateTime.Now.Month}.{DateTime.Now.Day}.txt";
        if (File.Exists(path))
            File.Create(path).Close();
        return path;
    }
    public static void WriteToLog(string NameProject,string nameFunc, string massege)
    {
        using (StreamWriter sw = new StreamWriter(GetThisfile(), true))
        {
            sw.WriteLine($"{DateTime.Now}\t{NameProject}.{nameFunc}:\t{massege}");
        }
    }
    public static void DeleteOldDir()
    {
        int prev =DateTime.Now.Month - 2;
        string[] Dirs = Directory.GetDirectories(log_Path);
        foreach (string dir in Dirs) 
        { 

            if(!(dir== (DateTime.Now.Year)+"."+(DateTime.Now.Month-1)|| dir == (DateTime.Now.Year) + "." + (DateTime.Now.Month)))
                Directory.Delete(dir, true);

        }
    }
}
