using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	[HideInInspector]
	public bool hasKey = false;
	public GameObject keyUI;
	public GameObject unlockText;
	public AudioClip openDoor;

	bool locked = true;
	AudioSource audioSource;
	Animator anim;
	BoxCollider boxer;

	void Awake()
	{
		audioSource = GetComponent<AudioSource> ();
		anim        = GetComponent<Animator> ();
		boxer 		= GetComponent<BoxCollider> ();
	}

    public void OnDoorClicked() 
	{

		if (locked && !hasKey) 
		{
			audioSource.Play ();
		}
		if (locked && hasKey) 
		{
			audioSource.clip = openDoor;
			audioSource.Play ();
			keyUI.SetActive (false);
			unlockText.SetActive (true);
			locked = false;
		}
		if (!locked)                   // MOVE THIS "IF" TO LINE 25 IF YOU WANT TO HAVE TO CLICK ONE TIME TO UNLOCK AND ONE TO OPEN
		{
			audioSource.Play ();
			anim.SetTrigger ("Open");
			boxer.enabled = false;
		}
    }
}
