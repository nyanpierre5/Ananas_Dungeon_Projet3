using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGlace : MonoBehaviour
{
    public LayerMask _WhatIsWall;
    public LayerMask _WhatIsAlive;

    public float _DommageHit;

    [Header("Glace")]
    public float _DurationSlow;
    public float _TauxSlow;

    private void OnTriggerEnter(Collider other) 
    {
        if(_WhatIsWall.Contains(other.gameObject.layer))
        {
            Destroy(gameObject);
        }

        if(_WhatIsAlive.Contains(other.gameObject.layer))
        {
            other.gameObject.GetComponent<LifePoint>().LostHealth(_DommageHit);
            other.gameObject.GetComponent<MoveIA>().Slow(_DurationSlow , _TauxSlow);

            Debug.Log("Glace");
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
            other.gameObject.GetComponent<LifePoint>().LostHealth(_DommageHit);
            other.gameObject.GetComponent<MoveIA>().Slow(_DurationSlow , _TauxSlow);
            
            Debug.Log("Glace");
            Destroy(gameObject);
        }
    }
}
