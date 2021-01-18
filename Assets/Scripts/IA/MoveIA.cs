using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIA : MonoBehaviour
{
    public CharacterController _CharacterController;
    public float _Speed;
    public float _InitialSpeed;
    public float _SpeedRotate;
    public float _InitialSpeedRotate;
    public Transform _PointForwardLocal;
    private GameObject _Player;

    public bool _ModePattrol;
    public bool _ModeHunt;
    public LayerMask _WhatIsWall;

    public float _InitialHauteur;

    void Start()
    {
        _InitialHauteur = transform.position.y;
        _InitialSpeed = _Speed;
        _InitialSpeedRotate = _SpeedRotate;
        _Player = GameObject.FindGameObjectWithTag("Player");
        lookAtPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 DirectionRaycast = new Vector3(_Player.transform.position.x - transform.position.x,_Player.transform.position.y - transform.position.y, _Player.transform.position.z - transform.position.z);

        if(Physics.Raycast(transform.position , DirectionRaycast, out hit , CalculDistanceWithPlayer(), _WhatIsWall))
        {
            //Debug.Log("Can't Hunt");
            _ModePattrol = true;
            _ModeHunt = false;
        }
        else
        {
            //Debug.Log("Can Hunt");
            _ModePattrol = false;
            _ModeHunt = true;
        }
        Debug.DrawRay(transform.position, DirectionRaycast, Color.red);
        
        
        if(_ModePattrol)
        {
            MoveForward();
            RotateY(Time.deltaTime * _SpeedRotate);
        }
        
        if(_ModeHunt)
        {
            lookAtPlayer();
            MoveForward();
        }

        ActualiseHauteur();
    }

    public void MoveForward()
    {
        Vector3 _DirectionLookAt = new Vector3(_PointForwardLocal.position.x - transform.position.x, _PointForwardLocal.position.y - transform.position.y,_PointForwardLocal.position.z - transform.position.z);
        _CharacterController.Move(_DirectionLookAt * _Speed * Time.deltaTime);
    }

    public void RotateY(float angleY)
    {
        transform.Rotate(0, angleY, 0, Space.Self);
    }

    void lookAtPlayer()
    {
        Vector3 PosPlayer  = new Vector3(_Player.transform.position.x , transform.position.y , _Player.transform.position.z);
        transform.LookAt(PosPlayer);
    }

    float CalculDistanceWithPlayer()
    {
        float DistanceWithPlayer = Vector3.Distance(_Player.transform.position, transform.position);
        return DistanceWithPlayer;
    }

    Vector3 DirectionPlayer()
    {
        Vector3 DirectionPlayer = new Vector3(_Player.transform.position.x - transform.position.x,_Player.transform.position.y - transform.position.y, _Player.transform.position.z - transform.position.z);
        return DirectionPlayer;
    }

    public void Slow(float Duration, float TauxSlow)
    {
        float NewSpeed = _InitialSpeed * TauxSlow;
        if(_Speed != _InitialSpeed && _Speed < NewSpeed)
        {
            //Ne slow pas
        }
        else
        {
            //Slow
            _Speed = NewSpeed;
        }

        StopAllCoroutines();
        StartCoroutine(WaitSlow(Duration));
    }

    public void ActualiseHauteur()
    {
        transform.position = new Vector3(transform.position.x , _InitialHauteur ,transform.position.z);
    }

    IEnumerator WaitSlow(float Duration) 
    {
        yield return new WaitForSeconds(Duration);
        _Speed = _InitialSpeed;
    }
}
