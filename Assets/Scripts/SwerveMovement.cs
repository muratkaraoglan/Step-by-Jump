using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveMovement : MonoBehaviour
{
     SwerveInput swerveInput;
    [SerializeField] private float speed = 4f;
    [SerializeField] private float xRange = 1f;
    private void Awake()
    {
        swerveInput = GetComponent<SwerveInput>();
    }
    void Update()
    {
        float moveAmount = swerveInput.MoveXOffset * Time.deltaTime * speed;
        moveAmount = Mathf.Clamp(moveAmount, -xRange, xRange);
        //Debug.Log(moveAmount);
        //transform.Translate(moveAmount, 0, 0);
        moveAmount = Mathf.Lerp(transform.position.x, moveAmount, Time.deltaTime * speed);
        transform.position = new Vector3(moveAmount, transform.position.y, transform.position.z);
        
    }

}
