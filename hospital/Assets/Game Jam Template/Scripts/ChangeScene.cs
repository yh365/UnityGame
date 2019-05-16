using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour {
	public Text Role;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeGameScene()
    {
		if (Role.text == "술래") {
			OnMouseSound.instance.PlaySound ();
			Thread.Sleep (600);
			SceneManager.LoadScene ("MemoryScene");
		} else if (Role.text == "숨기") {
			OnMouseSound.instance.PlaySound ();
			PNum.PlayerNum = 0;
			Thread.Sleep (600);
			SceneManager.LoadScene ("HideScene");
		}

    }
}
