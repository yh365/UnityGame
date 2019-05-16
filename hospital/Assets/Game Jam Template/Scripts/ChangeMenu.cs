using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class ChangeMenu : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeMenuScene()
    {
		OnMouseSound.instance.PlaySound ();
		Thread.Sleep (600);
        SceneManager.LoadScene("Menu");
    }
}
