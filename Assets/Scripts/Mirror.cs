using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
    public GameObject mirror;
    public GameObject mirrorCam;
    public GameObject playerCam;
    void Start()
    {
        
    }

    void Update()
    {
        mirrorCam.transform.position = Vector3.Scale(- NormalVec(mirror), mirror.transform.position - playerCam.transform.position);
    }

    private Vector3 NormalVec(GameObject plane)
    {
        Quaternion planeRot = plane.transform.rotation;
        return planeRot.eulerAngles;
    }
}
