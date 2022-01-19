using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class shopItem : MonoBehaviour
{
    int moneyAmount;
    int isRifleSold;
    public Text moneyAmountText;
    public Text heartPrice;
    public Button buyButton;

    public Text Log;
    // Start is called before the first frame update
    void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
    }

    // Update is called once per frame
    void Update()
    {
        moneyAmountText.text = "Money: " + moneyAmount.ToString() + " coin";
    }

    public void buyHeart()
    {

        if (moneyAmount >= 5)
        {
            moneyAmount -= 5;
        }
        else
        {
            Log.text = "Tiền Đâu Mà Mua";
        }
    }
    public void exitShop()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        SceneManager.LoadScene("SampleScene");
    }
}
