using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
	public ParticleSystem poofer;//Create a reference to the CoinPoofPrefab
	public static int totalSpawn = 0;

	private CoinCounter cc;
	private bool alreadySubtracted = false;


	void Awake()
	{
		cc = (CoinCounter)GameObject.FindGameObjectWithTag ("CoinCounter").GetComponent<CoinCounter> ();
		totalSpawn++;
	}

    public void OnCoinClicked()
	{
		Instantiate (poofer, transform.position, Quaternion.Euler(-90f, 0f, 0f));
		totalSpawn--;
		alreadySubtracted = true;
		cc.CoinCollected ();
		Destroy (gameObject);
    }

	void OnDestroy()
	{
		if (!alreadySubtracted)	totalSpawn--;
	}

}
