using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
	public GameObject poofer;
	public GameObject keyUI; 
	public Door door;
	public AudioClip keySound;
    //Create a reference to the KeyPoofPrefab and Door



	void Update()
	{
		transform.position = new Vector3(transform.position.x, 1 + (Mathf.Sin(Time.time*5)/3), transform.position.z);
	}

	public void OnKeyClicked()
	{
		keyUI.SetActive (true);
		GameObject fx = Instantiate (poofer, transform.position, Quaternion.Euler (-90f, 0f, 0f)) as GameObject;
		AudioSource audioSource = fx.GetComponent<AudioSource> ();
		audioSource.clip = keySound;
		audioSource.Play ();
		door.hasKey = true; 
		Destroy (gameObject);
    }

}
