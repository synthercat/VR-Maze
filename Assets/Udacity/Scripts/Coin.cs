using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
	public GameObject poofer;                //Create a reference to the CoinPoofPrefab
	public static int totalSpawn = 0;        //Static int for easy maintance for remaining keys

	private CoinCounter cc;
	private bool alreadySubtracted = false;


	void Awake()
	{
		cc = (CoinCounter)GameObject.FindGameObjectWithTag ("CoinCounter").GetComponent<CoinCounter> ();
		totalSpawn++;
	}

    public void OnCoinClicked()
	{
		GameObject fx = Instantiate (poofer, transform.position, Quaternion.Euler (-90f, 0f, 0f)) as GameObject;
		AudioSource audioSource = fx.GetComponent<AudioSource> ();
		audioSource.Play ();
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
