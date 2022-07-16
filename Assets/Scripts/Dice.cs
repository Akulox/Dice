using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public int row;
    public int col;
    public int verticalRot;
    public int horizontalRot;
    public int clockRot;
    
    void Start()
    {
        
    }

    public void RotateVertical(bool toUp)
    {
        verticalRot = (toUp ? ++verticalRot : --verticalRot) == 4 ? 0 : verticalRot;
        transform.rotation = Quaternion.AngleAxis(verticalRot * 90, Vector3.up);
        var rotation = transform.rotation;
        rotation = new Quaternion(rotation.x, rotation.y, rotation.z, rotation.w);
        transform.rotation = rotation;
    }
}
