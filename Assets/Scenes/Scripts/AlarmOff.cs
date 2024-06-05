using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmOff : MonoBehaviour
{

    AudioSource Alarm;
    void SomeFunction()
    {
        // 오디오 소스를 끄기
        Alarm.Stop();
    }

}
