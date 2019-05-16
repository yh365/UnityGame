using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSize : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetSize()
	{
		Screen.SetResolution (1600, 900, false);
	}

	public void SetSize2()
	{
		Screen.SetResolution (1920, 1080, false);
	}


}
