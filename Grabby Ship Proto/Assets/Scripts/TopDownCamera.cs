using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCamera : MonoBehaviour
{
    #region Variables
    public Transform m_Target;
    public float m_Height = 20f;
    public float m_Distance = 0f;
    public float m_Angle = 0f;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        HandleCamera();
    }

    // Update is called once per frame
    void Update()
    {
        HandleCamera();
    }

    protected virtual void HandleCamera()
    {
        if (!m_Target)
        {
            return;
        }

        /*Build World Position Vector.
        Vector3 worldPostition = (Vector3.forward * m_Distance) + (Vector3.up * m_Height);
        Debug.DrawLine(m_Target.position, worldPostition, Color.red);

        //Build Rotated vector
        Vector3 rotatedVector = Quaternion.AngleAxis(m_Angle, Vector3.up) * worldPostition;
        Debug.DrawLine(m_Target.position, rotatedVector, Color.green);

        //Move position
        Vector3 flatTargetPosition = m_Target.position;
        flatTargetPosition.y = 1f;
        Vector3 finalPosition = flatTargetPosition + rotatedVector;
        Debug.DrawLine(m_Target.position, finalPosition, Color.blue);*/

        Vector3 worldPostition = m_Target.position + (Vector3.up * m_Height);

        transform.position = worldPostition;

    }
}
