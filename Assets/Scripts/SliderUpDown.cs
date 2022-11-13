using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderUpDown : MonoBehaviour
{
    public float speed;
    private Vector3 pos;

    public void Start()
    {
        speed = 1.2f;
        pos = transform.position;
    }

    public void Update()
    {
        transform.position = new Vector3(0, speed, 0);
    }

    public void change(float newSpeed)
    {
        speed = newSpeed;
    }

}

