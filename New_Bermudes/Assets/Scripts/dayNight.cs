using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayNight : MonoBehaviour
{
    public Light dl;
    public float fullDay = 30f;
    [Range(0, 1)] public float TimeOfDay;
    private float sunIntensity;
    public AnimationCurve SunCurve;
    public GameObject monster;
    private void Start()
    {
        sunIntensity = dl.intensity;
    }
    private void Update()
    {
        TimeOfDay += Time.deltaTime / fullDay;
        if (TimeOfDay > 1)
        {
            TimeOfDay -= 1;
        }
        dl.transform.localRotation = Quaternion.Euler(TimeOfDay * 360f, 180, 0);
        sunIntensity = sunIntensity * SunCurve.Evaluate(TimeOfDay);//0.5
    }
}