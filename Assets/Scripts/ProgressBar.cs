using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public GameObject Player;
    public Transform Finish;
    public Slider Slider;

    private float _startZ;

    private void Start()
    {
        _startZ = Player.transform.position.z;
    }

    private void Update()
    {
        float currentZ = Player.transform.position.z;
        float finishZ = Finish.position.z;
        float t = Mathf.InverseLerp(_startZ, finishZ, currentZ);
        Slider.value = t;
    }
}
