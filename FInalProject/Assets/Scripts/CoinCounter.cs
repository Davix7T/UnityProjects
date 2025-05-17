using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    private int coins = 0;

    void Start()
    {
        UpdateCoinText();
    }

    public void AddCoin()
    {
        coins++;
        UpdateCoinText();
    }

    void UpdateCoinText()
    {
        coinText.text = "Monedas: " + coins;
    }
}
