using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI coinCounterText;
    private int coinCounter;

    void Start() {
        coinCounter = 0;
    }

    public void AddCoin() {
        coinCounter += 1;
        coinCounterText.text = coinCounter.ToString();
    }

}
