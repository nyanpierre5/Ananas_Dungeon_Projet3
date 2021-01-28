using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeMob : MonoBehaviour
{
    public GameObject _MyParent;
    public LayerMask _WhatIsPlayer;
    public float _Dommage;
    public GameObject ExplodeParticle;


    void Start()
    {
        //ExplodeParticle = GameObject.Find("Explode").GetComponent<ParticleSystem>();
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(_WhatIsPlayer.Contains(other.gameObject.layer))
        {
            Instantiate(ExplodeParticle, transform.position, Quaternion.identity);
            //ExplodeParticle.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
           // ExplodeParticle.Emit();

            other.gameObject.GetComponent<LifePoint>().LostHealth(_Dommage);
            Destroy(_MyParent);
        }
    }
}
