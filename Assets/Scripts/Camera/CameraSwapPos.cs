using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwapPos : MonoBehaviour
{
    public LayerMask _WhatIsPlayer;
    private GameObject _Camera;
    public CameraMove _CameraMove;
    public Transform _MyAncreCamera;

    public bool _PlayerIsHer = false;

    public bool _FirstIntantiate = false;
    public bool _DoorIsLoocked;
    public GameObject _GrillageDoor;

    public SpawnMonster _SpawnMonster;

    private void Start() 
    {
        _FirstIntantiate = true;
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

    private void Update() 
    {
        if(_PlayerIsHer)
        {
            if(_FirstIntantiate)
            {
                _FirstIntantiate = false;
                InstantiateSalle();
            }
        }
        if(_SpawnMonster == null)
        {
            EndChallengeRoom();
        }
    }

    public void InstantiateSalle()
    {
        _GrillageDoor.SetActive(true);
        _GrillageDoor.GetComponent<GrillageScaler>().Spawn(); 
        _SpawnMonster.Instantiate();
    }

    public void EndChallengeRoom()
    {
        _GrillageDoor.SetActive(false);
    }
}
