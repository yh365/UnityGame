using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public TimerManager time;
    public Text GameOverText;
    Animator anim;
    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    // Use this for initialization
    void Start()
    {
        GameOverText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (!time.chkState)
        {
            GameOverText.text = "GameOver !";
            anim.SetTrigger("GameOver");
        }
    }
}
