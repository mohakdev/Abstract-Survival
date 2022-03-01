using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraShake : MonoBehaviour
{
    public static CameraShake Instance { get; private set; }
    private CinemachineVirtualCamera VirtualCam;
    private float ShakeTimer = 0f;
    private void Awake()
    {
        Instance = this;
        VirtualCam = GetComponent<CinemachineVirtualCamera>();
    }
    public void StartShake(float intensity, float timer)
    {
        CinemachineBasicMultiChannelPerlin CBMCP =
        VirtualCam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

        CBMCP.m_AmplitudeGain = intensity;
        ShakeTimer = timer;
    }
    private void Update()
    {
        if (ShakeTimer > 0)
        {
            ShakeTimer -= Time.deltaTime;
            if (ShakeTimer <= 0)
            {
                //Time Over
                CinemachineBasicMultiChannelPerlin CBMCP =
                VirtualCam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

                CBMCP.m_AmplitudeGain = 0;
            }
        }
    }
}
