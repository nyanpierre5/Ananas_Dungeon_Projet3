using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwapPos : MonoBehaviour
{
    public LayerMask _WhatIsPlayer;
    private GameObject _Camera;
    public CameraMove _CameraMove;
    public Transform _MyAncreCamera;

    private bool _PlayerIsHer = false;

    private void Start() 
    {
        _Camera = GameObject.FindGameObjectWithTag("MainCamera");
        _CameraMove = _Camera.GetComponent<CameraMove>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(_WhatIsPlayer.Contains(other.gameObject.layer) && _PlayerIsHer == false)
        {
            _PlayerIsHer = true;
            _CameraMove.MoveAtPos(_MyAncreCamera.position);
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        _PlayerIsHer = false;
    }
}
