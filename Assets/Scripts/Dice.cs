using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public int row;
    public int col;
    public int verticalRot;
    public int horizontalRot;
    public int clockwiseRot;

    private float smooth = 10f;
    private Quaternion qEnd;
    
    void Start()
    {
        
    }

    public void RotateVertical(bool toUp)
    {
        verticalRot = (toUp ? ++verticalRot : --verticalRot) == 4 ? 0 : verticalRot;
    }
    public void RotateHorizontal(bool toRight)
    {
        horizontalRot = (toRight ? ++horizontalRot : --horizontalRot) == 4 ? 0 : horizontalRot;
    }
    public void RotateClockwise(bool toClockwise)
    {
        clockwiseRot = (toClockwise ? ++clockwiseRot : --clockwiseRot) == 4 ? 0 : clockwiseRot;
    }

    private void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(new Vector3(verticalRot*90, horizontalRot*90, clockwiseRot*90)), Time.deltaTime* smooth);
    }
}
