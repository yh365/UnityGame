using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySound : MonoBehaviour {

    public AudioClip soundExplosion;
    AudioSource myAudio;

    public static DestroySound instance;

    private void Awake() // start 함수보다 먼저 호출됨
    {
        if(DestroySound.instance == null)
        {
            DestroySound.instance = this;
        }
    }

    // Use this for initialization
    void Start () {
        myAudio = GetComponent<AudioSource>();
	}

    public void PlaySound()
    {
        myAudio.PlayOneShot(soundExplosion); // soundExplosion 안에 있는 사운드가 재생
    }

    // Update is called once per frame
    void Update () {
		
	}
}
