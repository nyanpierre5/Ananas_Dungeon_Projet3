using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{   

    public LayerMask _WhatIsWall;
    public LayerMask _WhatIsAlive;

    public float _DommageHit;
    
    [Header("OnBurn")]
    public float _DommagePerHitBurn;
    public int _NbTicBurn;

    private void OnTriggerEnter(Collider other) 
    {
        if(_WhatIsWall.Contains(other.gameObject.layer))
        {
            Destroy(gameObject);
        }

        if(_WhatIsAlive.Contains(other.gameObject.layer))
        {
            other.gameObject.GetComponent<DropMonstre>().LostHealth(_DommageHit);
            other.gameObject.GetComponent<DropMonstre>().OnBurn(_NbTicBurn , _DommagePerHitBurn);

            Debug.Log("Fire");
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(_WhatIsWall.Contains(other.gameObject.layer))
        {
            Destroy(gameObject);
        }
        
        if(_WhatIsAlive.Contains(other.gameObject.layer))
        {
            other.gameObject.GetComponent<DropMonstre>().LostHealth(_DommageHit);
            other.gameObject.GetComponent<DropMonstre>().OnBurn(_NbTicBurn , _DommagePerHitBurn);

            Debug.Log("Fire");
            Destroy(gameObject);
        }
        
    }
}
