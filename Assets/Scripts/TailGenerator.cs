using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailGenerator : MonoBehaviour
{
    public GameObject[] TailPrefabs;
    public int MinTails;
    public int MaxTails;
    public float DistanceBetweenTails;

    private void Awake()
    {
        int tailsCount = Random.Range(MinTails, MaxTails + 1);

        for (int i = 0; i < tailsCount; i++)
        {
            int prefabIndex = Random.Range(0, TailPrefabs.Length);
            Vector3 position = new Vector3(0, DistanceBetweenTails * i, 0);
            Quaternion rotation = Quaternion.Euler(0, Random.Range(0, 360f), 0);
            Instantiate(TailPrefabs[prefabIndex], position, rotation, transform);
        }
    }
}
