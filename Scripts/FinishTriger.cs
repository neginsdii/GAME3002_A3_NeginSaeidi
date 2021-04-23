using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTriger : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene("WinScene", LoadSceneMode.Single);
		}
	}
}
