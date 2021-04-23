using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedupTrigger : MonoBehaviour
{
    
	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
            BirdMovement.jumpSpeed = 12.0f;
		}
	}
}
