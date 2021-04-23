using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerCountDown : MonoBehaviour
{
    public Text textDisplay;
    public float timeValue = 120;

    // Start is called before the first frame update
    void Start()
    {
        textDisplay = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }
        DisplayTime(timeValue);

        
    }
    void DisplayTime(float timeToDisplay)
	{
        if(timeToDisplay <0)
		{
            timeToDisplay = 0;
		}
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        textDisplay.text = string.Format("Time Left {0:00}:{1:00}", minutes, seconds);
        if(minutes ==0 && seconds == 0)
		{
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOverScene", LoadSceneMode.Single);
        }
	}
}
