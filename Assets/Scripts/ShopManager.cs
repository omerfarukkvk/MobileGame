using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public Text CoinText;
    public Text speedPriceText;
    public Text itemTwoPriceText;
    public Text itemThreePriceText;
    public Text itemFourPriceText;
    public GameObject player;
    public ItemsManager itemsManager;
    
    void Start()
    {
        AssigmentFunc();
        StringFunc();
    }

    void Update()
    {
        CoinText.text = "Coins: " + PlayerPrefs.GetInt("Coins").ToString();
        StringFunc();
    }

    public void OnClickSpeed()
    {
        if (itemsManager.ItemsList[0].Level < itemsManager.ItemsList[0].maxLevel && PlayerPrefs.GetInt("Coins") >= itemsManager.ItemsList[0].Price && PlayerPrefs.GetInt("Coins") >= 0)
        {
            PlayerPrefs.SetInt("SpeedLevel", PlayerPrefs.GetInt("SpeedLevel") + 1);
            itemsManager.ItemsList[0].Level = PlayerPrefs.GetInt("SpeedLevel");
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - itemsManager.ItemsList[0].Price);
            PlayerPrefs.SetFloat("waitForPlayer", PlayerPrefs.GetFloat("waitForPlayer") - 0.3f);
            itemsManager.ItemsList[0].Price *= 2;
            PlayerPrefs.SetInt("SpeedPrice", itemsManager.ItemsList[0].Price);
        }
    }

    private void StringFunc()
    {
        itemsManager.ItemsList[0].Price = PlayerPrefs.GetInt("SpeedPrice"); //hataaaaa
        CoinText.text = "Coins: " + PlayerPrefs.GetInt("Coins").ToString();
        speedPriceText.text = "Price: " + itemsManager.ItemsList[0].Price.ToString();
        itemTwoPriceText.text = "Price: " + itemsManager.ItemsList[1].Price.ToString();
        itemThreePriceText.text = "Price: " + itemsManager.ItemsList[2].Price.ToString();
        itemFourPriceText.text = "Price: " + itemsManager.ItemsList[3].Price.ToString();
    }

    private void AssigmentFunc()
    {
        //PlayerPrefs.SetFloat("waitForPlayer", 2f);
        //PlayerPrefs.SetInt("SpeedLevel", 0);
        //PlayerPrefs.SetInt("SpeedPrice", 10);
        itemsManager = GameObject.Find("Canvas/Items").GetComponent<ItemsManager>();
    }
}
