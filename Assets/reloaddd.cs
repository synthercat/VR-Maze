using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reloaddd : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("Relo", 5f);
	}
	
	// Update is called once per frame
			void Relo()
	{
		SceneManager.LoadScene ("MyScene2");
	}
}
