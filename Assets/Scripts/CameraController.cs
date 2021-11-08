using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform ball;
    public Vector3 offset;
    void Start()
    {
        offset = transform.position - ball.position;
    }
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, ball.position + offset, Time.deltaTime * 10f);
    }
}
