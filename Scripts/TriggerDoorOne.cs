using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorOne : MonoBehaviour
{
    
	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
            OpenDoor.doorOne = true;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			OpenDoor.doorOne = false;
		}
	}

}
