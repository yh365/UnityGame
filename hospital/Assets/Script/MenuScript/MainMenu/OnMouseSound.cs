using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseSound : MonoBehaviour {

	public AudioClip sound;
	AudioSource myAudio;

	public static OnMouseSound instance;

	private void Awake() // start 함수보다 먼저 호출됨
	{
		if(OnMouseSound.instance == null)
		{
			OnMouseSound.instance = this;
		}
	}

	// Use this for initialization
	void Start () {
		myAudio = GetComponent<AudioSource>();
	}

	public void PlaySound()
	{
		myAudio.PlayOneShot(sound); // soundExplosion 안에 있는 사운드가 재생
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
