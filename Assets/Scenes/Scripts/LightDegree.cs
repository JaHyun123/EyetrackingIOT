using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDegree : MonoBehaviour
{
    public Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        myLight.intensity = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        myLight.intensity -= 0.001f;

        // ��Ⱑ 0 ���Ϸ� ���� �ʵ��� ����
        if (myLight.intensity <= 0f)
        {
            myLight.intensity = 0f;
        }
    }
    void LightUp()
    {
        myLight.intensity += 0.001f;
    }
    void LightDown()
    {
        myLight.intensity -= 0.001f;
    }
}