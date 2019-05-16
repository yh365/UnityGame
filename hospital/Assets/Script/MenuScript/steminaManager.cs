using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class steminaManager : MonoBehaviour
{
    public Slider progress;
    public float maxStemina = 100;
    public float fillStemina = 0.5f;//Unity Slider Script부분에서 편집가능(VisualStudio에서는 안됨)
    public float minusStemina = -0.5f;//Unity Slider Script부분에서 편집가능(VisualStudio에서는 안됨)\

	float timeSpan;
	float checkTime;

    // Use this for initialization
    void Start()
    {
		timeSpan = 0.0f;
		checkTime = 20.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))))
        {
			if (GameObject.FindGameObjectsWithTag ("item").Length == 2)
			{
				progress.value += minusStemina;
				timeSpan = 0;
			}
			else if (GameObject.FindGameObjectsWithTag ("item").Length == 1)
			{
				timeSpan += Time.deltaTime;
				if (timeSpan < checkTime)
				{
					progress.value += 0;
				}
				else
				{
					progress.value += minusStemina;
				}
			}

        }//쉬프트+방향키눌렸을시 스테미너 다운+플레이어 속도업
        else
		{
			if (GameObject.FindGameObjectsWithTag ("item").Length == 1) 
			{
				timeSpan += Time.deltaTime;
			}

			progress.value += fillStemina;
		}     

    }//그 이외의 모든 상황에서 스테미너 업+플레이어 속도 다운

}
