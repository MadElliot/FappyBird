using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicroInput : MonoBehaviour
{

    public static float volume;

    AudioClip microRecord;
    string device;           //设备名字

    void Start()
    {
        device = Microphone.devices[0];
        microRecord = Microphone.Start(device, true, 999, 44100);
    }

    void Update()
    {
        volume = GetMaxVolume();
    }

    float GetMaxVolume()
    {
        float maxVolume = 0f;
        float[] volumeData = new float[128];
        int offset = Microphone.GetPosition(device) - 128 + 1;

        if (offset < 0)
        {
            return 0;
        }
        microRecord.GetData(volumeData, offset);

        for (int i = 0; i < 128; i++)
        {
            float tempMax = volumeData[i];
            if (maxVolume < tempMax)
            {
                maxVolume = tempMax;
            }
        }
        return maxVolume;
    }
}
