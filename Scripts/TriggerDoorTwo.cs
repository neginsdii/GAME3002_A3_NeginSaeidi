using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorTwo : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			OpenDoorTwo.doorOne = true;
		}
	}
	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			OpenDoorTwo.doorOne = false;
		}
	}
}
