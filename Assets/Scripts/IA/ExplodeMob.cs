using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeMob : MonoBehaviour
{
    public GameObject _MyParent;
    public LayerMask _WhatIsPlayer;
    public float _Dommage;

    private void OnTriggerEnter(Collider other) 
    {
        if(_WhatIsPlayer.Contains(other.gameObject.layer))
        {
            other.gameObject.GetComponent<LifePoint>().LostHealth(_Dommage);
            Destroy(_MyParent);
        }
    }
}
