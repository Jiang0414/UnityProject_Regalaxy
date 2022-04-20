using LitJson;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public class J_LoginCheck : MonoBehaviour
{
    public static J_LoginCheck _instance = null;

    public static J_LoginCheck Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new J_LoginCheck();
            }
            return _instance;
        }
    }

    public void WriteJson(string path, LoginData content)
    {
        StringBuilder sb = new();
        JsonWriter jr = new(sb)
        {
            PrettyPrint = true,
            IndentValue = 4
        };

        JsonMapper.ToJson(content, jr);
        File.WriteAllText(path, sb.ToString());
    }

    public LoginData JsonToLogin(string path)
    {
        return JsonMapper.ToObject<LoginData>(path);
    }
}
public class LoginData
{
   public Dictionary<string, bool> CheckInDay { get; set; }
   public string CheckTime { get; set; }
}

