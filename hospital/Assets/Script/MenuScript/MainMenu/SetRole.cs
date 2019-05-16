using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetRole : MonoBehaviour {

	public Text Role;
	public GameObject Off; 

	// Use this for initialization
	void Start () {
		Off.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeRole()
	{
		Role.text = "술래";
		OnMouseSound.instance.PlaySound ();
		Off.SetActive(true);
	}

	public void ChangeRole2()
	{
		Role.text = "숨기";
		OnMouseSound.instance.PlaySound ();
		Off.SetActive(false);
	}
}
