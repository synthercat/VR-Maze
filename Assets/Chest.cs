using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour {

	public GameObject resetUI;

	Animator anim;
	BoxCollider boxer;

	void Awake()
	{
		anim  = GetComponent<Animator> ();
		boxer = GetComponent<BoxCollider> ();
	}
	

	public void OnClick()
	{
		anim.SetTrigger ("Open");
		resetUI.SetActive (true);
		boxer.enabled = false;
	}
}
