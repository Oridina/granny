using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float degreesPerSecond = 30;

    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.forward, degreesPerSecond * Time.deltaTime);
    }
}
