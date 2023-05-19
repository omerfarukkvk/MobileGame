using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Items
{
    public string Name;
    public int Price;
    public int maxLevel;
    public int Level = 0;
}

public class ItemsManager : MonoBehaviour
{
    public List<Items> ItemsList = new List<Items>();
    void Start()
    {
        //ItemsList[0].Price = PlayerPrefs.GetInt("SpeedPrice");
    }

    void Update()
    {
        PlayerPrefs.SetInt("SpeedPrice", ItemsList[0].Price);
        ItemsList[0].Level = PlayerPrefs.GetInt("SpeedLevel");
    }
}
