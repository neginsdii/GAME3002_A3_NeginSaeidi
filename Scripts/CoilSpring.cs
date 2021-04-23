using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoilSpring : MonoBehaviour
{
    [SerializeField]
    private float m_fSpringConstant = -25;
    [SerializeField]
    private float m_fDampingConstant = 45;
    [SerializeField]
    private Vector3 m_vRestPos;
    [SerializeField]
    private float m_fMass;
    [SerializeField]
    private Rigidbody m_attachedBody = null;
    [SerializeField]
    private bool m_bIsBungee = false;

    private Vector3 m_vForce;
    private Vector3 m_vPrevVel;

    private void Start()
    {
        m_fMass = m_attachedBody.mass;

      
    }

    private void FixedUpdate()
    {
        UpdateSpringForce();
    }

    private float CalculateSpringConstant()
    {

        float fDX = (m_vRestPos - m_attachedBody.transform.position).magnitude;

        if (fDX <= 0f)
        {
            return Mathf.Epsilon;
        }

        return (m_fMass * Physics.gravity.y) / (fDX);
    }

    private void UpdateSpringForce()
    {


        m_vForce = -m_fSpringConstant * (m_vRestPos - m_attachedBody.transform.position) -
            m_fDampingConstant * (m_attachedBody.velocity - m_vPrevVel);

        m_attachedBody.AddForce(m_vForce, ForceMode.Acceleration);

        m_vPrevVel = m_attachedBody.velocity;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(m_vRestPos, 1f);

        if (m_attachedBody)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(m_attachedBody.transform.position, 1f);

            Gizmos.color = Color.blue;
            Gizmos.DrawLine(transform.position, m_attachedBody.transform.position);
        }
    }
}
