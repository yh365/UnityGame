using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingMenu : MonoBehaviour {

	public GameObject SettingUI;

	// Use this for initialization
	void Start () {
		SettingUI.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpenSetting()
	{
		OnMouseSound.instance.PlaySound ();
		SettingUI.SetActive(true);
	}

	public void Quit()
	{
		OnMouseSound.instance.PlaySound ();
		SettingUI.SetActive(false);
	}
}
