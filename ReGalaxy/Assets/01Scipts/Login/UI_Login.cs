using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LitJson;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;
using System;

public class UI_Login : MonoBehaviour
{
    public List<GameObject> imgDays;
    public List<GameObject> imgStages;
    private string path;
    public int year, mouth, day;
    public LoginData loginData = new();

    private void Start()
    {
        loginData.CheckInDay = new Dictionary<string, bool>();
        loginData.CheckTime = string.Empty;

        path = Application.dataPath + "/97Json/loginCheck.json";
        Transform days = transform.Find("Days");
        Transform stages = transform.Find("Stages");

        foreach (Transform day in days)
        {
            imgDays.Add(day.gameObject);
        }
        foreach (Transform stage in stages)
        {
            imgStages.Add(stage.gameObject);
        }

        Login(path);
        splidTime();
    }
    public void splidTime()
    {
        if (loginData.CheckTime == string.Empty) return;
        string[] time = loginData.CheckTime.Split("/"); ;
        year = int.Parse(time[0]);
        mouth = int.Parse(time[1]);
        day = int.Parse(time[2]);
    }
    public int GetTime(int index, string Time)
    {
        int time = 0;
        string[] _time = Time.Split("/");
        return time = int.Parse(_time[index]);
    }
    public void CreatLoginJson(string path)
    {
        foreach (var day in imgDays)
        {
            Transform state = day.transform.Find("state");
            string key = Regex.Replace(day.name, "[^0-9]", "");

            if (loginData.CheckInDay.ContainsKey(key))
                loginData.CheckInDay[key] = state.gameObject.activeInHierarchy;
            else
                loginData.CheckInDay.Add(key, state.gameObject.activeInHierarchy);
        }
        loginData.CheckTime = string.Empty;
        J_LoginCheck.Instance.WriteJson(path, loginData);
    }

    public void Login(string path)
    {
        if (!File.Exists(path))
        {
            CreatLoginJson(path);
        }
        else
        {
            SetLogin(File.ReadAllText(path));
        }
    }
    public void SetLogin(string path)
    {
        loginData = J_LoginCheck.Instance.JsonToLogin(path);

        for (int i = 0; i < imgDays.Count; i++)
        {
            Transform state = imgDays[i].transform.Find("state");
            state.gameObject.SetActive(loginData.CheckInDay[(i + 1).ToString()]);
        }
    }
    public string GetLatestDay()
    {
        string latesDay = string.Empty;
        for (int i = 0; i < imgDays.Count; i++)
        {
            if (!loginData.CheckInDay[(i + 1).ToString()] || !loginData.CheckInDay[(1).ToString()])
            {
                latesDay = i == 0 ? "1" : (i + 1).ToString();
                break;
            }
        }
        return latesDay;
    }

    public void BtnCheckIn(GameObject btn)
    {
        if (Regex.Replace(btn.name, "[^0-9]", "") != GetLatestDay() ||
            (loginData.CheckTime != string.Empty && GetTime(2, DateTime.Now.ToShortDateString()) <= GetTime(2, loginData.CheckTime)))
        {
            return;
        }

        Transform state = btn.transform.Find("state");
        loginData.CheckInDay[Regex.Replace(btn.name, "[^0-9]", "")] = true;
        loginData.CheckTime = DateTime.Now.ToShortDateString();
        state.gameObject.SetActive(true);
        J_LoginCheck.Instance.WriteJson(path, loginData);
    }
    public void BtnBonus(GameObject btn)
    {
        if (!loginData.CheckInDay[Regex.Replace(btn.name, "[^0-9]", "")]) return;

        Transform state = btn.transform.Find("state");
        state.gameObject.SetActive(true);
    }
}