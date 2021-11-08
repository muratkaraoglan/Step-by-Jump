using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveInput : MonoBehaviour
{
    private float fingerBeginX;
    private float moveXOffset;
    public float MoveXOffset { get { return moveXOffset; } }
    void Update()
    {
        if ( Input.GetMouseButtonDown(0) )
        {
            fingerBeginX = Input.mousePosition.x;
        }
        else if ( Input.GetMouseButton(0) )
        {
            moveXOffset = Input.mousePosition.x - fingerBeginX;
        }
        //else if ( Input.GetMouseButtonUp(0) )
        //{
        //    moveXOffset = 0f;
        //}
    }
}
