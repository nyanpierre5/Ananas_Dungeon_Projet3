using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTourIA : MonoBehaviour
{
    public Transform _ForwardTransform;
    public float _Speed;

    public float _Duration = 15;
    private float _Timer;

    public LayerMask _WhatIsWall;
    public float _Degats;

    // Update is called once per frame
    void Update()
    {
        MoveForward();
        
        _Timer += Time.deltaTime;
        if(_Timer >= _Duration)
        {
            Destroy(gameObject);
        }
        
    }

    public void MoveForward()
    {
        Vector3 DirectionLookAt = new Vector3(_ForwardTransform.position.x - transform.position.x, _ForwardTransform.position.y - transform.position.y,_ForwardTransform.position.z - transform.position.z);
        
        Vector3 DirectionNormalized = DirectionLookAt.normalized;

        Vector3 FuturPosition = transform.position + DirectionNormalized * Time.deltaTime * _Speed;
        transform.position = FuturPosition;
    }

    public void lookAtTarget(GameObject Target)
    {
        transform.LookAt(Target.transform);
    }


    private void OnTriggerEnter(Collider other) 
    {
        if(_WhatIsWall.Contains(other.gameObject.layer))
        {
            Debug.Log("Touch Wall");
            
            // Effect

            Destroy(gameObject);
        }

        if(other.tag == "Player")
        {
            Debug.Log("Touch Player");

            // Effect
            other.gameObject.GetComponent<LifePoint>().LostHealth(_Degats);

            Destroy(gameObject);
        }
    }
    
}
