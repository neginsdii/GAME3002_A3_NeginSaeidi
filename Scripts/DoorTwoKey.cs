using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTwoKey : MonoBehaviour
{
	// Start is called before the first frame update
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			OpenDoorTwo.doorOnekey = true;
			Debug.Log("PikUP");
			Destroy(gameObject);
		}
	}
}
