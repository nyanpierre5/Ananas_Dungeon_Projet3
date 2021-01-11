using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetecteurWall : MonoBehaviour
{

    public LayerMask _WhatIsWall;
    public MoveIA _MoveIA;

    private void OnTriggerEnter(Collider other) 
    {
        if(_WhatIsWall.Contains(other.gameObject.layer))
        {
            _MoveIA.RotateY(90);

            float randSpeed =  Random.Range(_MoveIA._InitialSpeedRotate * 0.5f ,_MoveIA._InitialSpeedRotate * 1.5f);
            _MoveIA._SpeedRotate = randSpeed;

            int randDirection = Random.Range(0,2);
            if(randDirection == 1)
            {
                _MoveIA._SpeedRotate = -_MoveIA._SpeedRotate;
            }
        }
    }

    private void OnTriggerStay(Collider other) 
    {
        if(_WhatIsWall.Contains(other.gameObject.layer))
        {
            _MoveIA.RotateY(1);
        }
    }
}
