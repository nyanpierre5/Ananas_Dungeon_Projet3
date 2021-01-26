using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotterIA : MonoBehaviour
{
    public GameObject _Player;
    public LayerMask _WhatIsWall;

    public float _FrequenceShot;
    private float _TimerFrequenceShot;

    public bool CanShot;
    public GameObject _Bullet;
    public Transform _PositionLaunchBullet;

    public GameObject _Canon;

    void Start()
    {
        _Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 DirectionRaycast = new Vector3(_Player.transform.position.x - transform.position.x,_Player.transform.position.y - transform.position.y, _Player.transform.position.z - transform.position.z);

        if(Physics.Raycast(transform.position , DirectionRaycast, out hit , CalculDistanceWithPlayer(), _WhatIsWall))
        {
            //Debug.Log("Can't Shot");
            CanShot = false;
        }
        else
        {
            //Debug.Log("Can Shot");
            CanShot = true;
            lookAtPlayer();
        }
        Debug.DrawRay(transform.position, DirectionRaycast, Color.blue);



        _TimerFrequenceShot += Time.deltaTime;
        if(CanShot && _TimerFrequenceShot >= _FrequenceShot)
        {
            GameObject LastBullet = Instantiate(_Bullet, _PositionLaunchBullet.position, Quaternion.identity);
            LastBullet.GetComponent<BulletTourIA>().lookAtTarget(_Player);
            _TimerFrequenceShot = 0;
        }

        
    }

    Vector3 DirectionPlayer()
    {
        Vector3 DirectionPlayer = new Vector3(_Player.transform.position.x - transform.position.x,_Player.transform.position.y - transform.position.y, _Player.transform.position.z - transform.position.z);
        return DirectionPlayer;
    }

    void lookAtPlayer()
    {
        _Canon.transform.LookAt(_Player.transform);
        Debug.Log("dege");
    }

    float CalculDistanceWithPlayer()
    {
        float DistanceWithPlayer = Vector3.Distance(_Player.transform.position, transform.position);
        return DistanceWithPlayer;
    }
}
