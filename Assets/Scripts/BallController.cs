using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float jumpForce;
    public float speed;


    Rigidbody rb;
    bool forward = false;

   
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if ( rb.velocity.y < 0.2f && rb.velocity.y > -0.2f && forward )
        {
            forward = false;
            StartCoroutine(SetPosition());
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        rb.velocity = Vector3.up * jumpForce * Time.deltaTime;
        forward = true;
    }

    IEnumerator SetPosition()
    {
        float t = 0.02f;
        float targetPosZ = transform.position.z + 1.3f;
        while ( t <= 1f )
        {
            Vector3 myPos = transform.position;
            Vector3 targetPos = new Vector3(myPos.x, myPos.y, targetPosZ);
            transform.position = Vector3.Lerp(myPos, targetPos, t * Time.deltaTime * speed);
            t += Time.deltaTime;
            yield return null;
        }
    }
}
