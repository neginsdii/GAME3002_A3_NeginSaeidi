using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public float restPosition = 0f;
    public float pressedPosition ;
    public float hitStrength ;
    public float flipperDamper ;
    public string flipperName;
    HingeJoint hinge;
    private JointSpring spring;
    public static bool doorOne = false;
    public static bool doorOnekey = false;
    private static bool isDoorOpen = false;
    public GameObject Door1Collision;
    public float timer = 3.0f;
    public bool showMessage = false;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
        spring = new JointSpring();
        spring.spring = hitStrength;
        spring.damper = flipperDamper;

        hinge.spring = spring;
    }

    // Update is called once per frame
    void Update()
    {
        if(showMessage)
		{
            if (timer < 0)
            {
                showMessage = false;
                text.SetActive(false);
                timer = 3.0f;
            }
            else
            {
                text.SetActive(true);
             
            }
            timer -= Time.deltaTime;
        }

        if(!isDoorOpen)
		{
            spring.targetPosition = restPosition;
        }
        if (Input.GetAxis("Open") == 1)
        {
            if (doorOne)
            {
                if (doorOnekey) { 
                    Door1Collision.SetActive(false);

                spring.targetPosition = pressedPosition;
                isDoorOpen = true;
                }
                else
				{
                    showMessage = true;
				}
            }

        }
        //else
        //{
        //    spring.targetPosition = restPosition;

        //}
        hinge.spring = spring;
        ////hinge.useLimits = true;
    }
}
