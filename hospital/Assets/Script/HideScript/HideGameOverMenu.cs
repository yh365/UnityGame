using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideGameOverMenu : MonoBehaviour {

	public GameObject GameOverUI;
	public bool chkPlayer;
    public bool chkGameover;
    public HideTimerManager hidetimermanager;

    // Use this for initialization
    void Start () {
        hidetimermanager = GameObject.Find("BlueSuitFree01").GetComponent<HideTimerManager>();
        GameOverUI.SetActive(false);
		chkPlayer = false;
        chkGameover = false;
    }

	// Update is called once per frame
	void Update ()
	{
        chkGameOver();

    }

	void OnCollisionEnter(Collision col)
	{
        if (col.transform.tag == "player")
        {
            chkGameover = true;
        }
        else
            chkGameover = false;

        
	}
    void chkGameOver()
    {
        if (chkGameover)
        {
            GameOverUI.SetActive(true);

            // Mouse Lock
            Cursor.lockState = CursorLockMode.None;

            // Cursor visible
            Cursor.visible = true;

            Time.timeScale = 0;
            chkPlayer = true;      
        }
        else
        {
            GameOverUI.SetActive(false);
            //Cursor.visible = false;
        }

    }

}
