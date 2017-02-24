using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoinCounter : MonoBehaviour {

	public Text coinText;
	int coinsCollected = 0;

	void Start()
	{
		coinText.text = "Coins : 0\nRemaining : " + Coin.totalSpawn;
	}

	public void CoinCollected()
	{
		coinsCollected++;
		coinText.text = "Coins : " + coinsCollected + "\nRemaining : " + Coin.totalSpawn;
	}

}
