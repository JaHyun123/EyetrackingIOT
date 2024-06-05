using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDegree : MonoBehaviour
{
    public Light myLight;
    public bool m_IsButtonDowning;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
 

        if (m_IsButtonDowning)
        {
            myLight.intensity += 0.001f;
        }
    }

    public void LightUp()
    {
        m_IsButtonDowning = true;
    }
    public void noDown()
    {
        m_IsButtonDowning = false;
    }

}