using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class PNum
{
	public static int PlayerNum;
}

public class SetPlayerNum : MonoBehaviour {

	public GameObject IncreaseUI;
	public GameObject DecreaseUI;
	public Text PlayerNumText;

	// Use this for initialization
	void Start () {
		PNum.PlayerNum = 3;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Increase()
	{
		if (PNum.PlayerNum == 6) {
			PNum.PlayerNum = 6;
		} 
		else 
		{
			PlayerNumText.text = (PNum.PlayerNum + 1).ToString ();
			PNum.PlayerNum += 1;
		}
		Debug.Log (PNum.PlayerNum);
		OnMouseSound.instance.PlaySound ();
	}

	public void Decrease()
	{
		if (PNum.PlayerNum == 1) {
			PNum.PlayerNum = 1;
		} 
		else 
		{
			PlayerNumText.text = (PNum.PlayerNum - 1).ToString ();
			PNum.PlayerNum -= 1;
		}
		Debug.Log (PNum.PlayerNum);
		OnMouseSound.instance.PlaySound ();
	}
}
