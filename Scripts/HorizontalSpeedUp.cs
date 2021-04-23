using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalSpeedUp : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			BirdMovement.jumpSpeed = 7.0f;
			BirdMovement.WalkSpeed = 9.0f;
		}

	}
}
