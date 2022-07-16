using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    // [SerializeField] private float cameraRadius = 20f;
    //
    // public GameObject CameraObject;
    // public GameObject CameraStart;
    // private Vector3 _startMousePos;
    // private float _buttonAngles;
    // private bool _drag;
    //
    // private void Start()
    // {
    //     CameraStart = CameraObject;
    // }
    //
    // public Animator GetAnimator()
    // {
    //     return transform.GetComponent<Animator>();
    // }
    //
    //
    // public void Restart()
    // {
    //     sceneController.Restart();
    // }
    //
    // public void Home()
    // {
    //     sceneController.Home();
    // }
    //
    // public void ResetCameraAngle()
    // {
    //     CameraObject.transform.position = CameraStart.transform.position;
    //     CameraObject.transform.rotation = CameraStart.transform.rotation;
    // }
    //
    // private void ChangeCameraPosition(float angle)
    // {
    //     if (!_drag) return;
    //     CameraObject.transform.position = new Vector3((float)Math.Cos(2*Math.PI/360 * (angle-90f)) * cameraRadius, cameraHeight, -(float) Math.Sin(2*Math.PI/360 * (angle-90f)) * cameraRadius);
    //     CameraObject.transform.rotation = Quaternion.AngleAxis(angle - 180, Vector3.up);
    // }
    //
    // private void Update()
    // {
    //     ChangeCameraPosition(buttons.transform.rotation.eulerAngles.z);
    // }
}
