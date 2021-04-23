using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1Key : MonoBehaviour
{
    
	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
            OpenDoor.doorOnekey = true;
            Debug.Log("PikUP");
			Destroy(gameObject);
		}
	}
}
