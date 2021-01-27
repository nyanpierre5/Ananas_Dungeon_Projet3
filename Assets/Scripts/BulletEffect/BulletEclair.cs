using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEclair : MonoBehaviour
{
    public LayerMask _WhatIsWall;
    public LayerMask _WhatIsAlive;

    public float _DommageHit;

    [Header("Eclair")]
    public Rigidbody _Rigidbody;
    public int _NbRebondMax = 3;
    private int _NbRebond = 0;
    public GameObject _LastHitted;

    private void OnTriggerEnter(Collider other) 
    {
        if(_WhatIsWall.Contains(other.gameObject.layer))
        {
            Destroy(gameObject);
        }

        if(_WhatIsAlive.Contains(other.gameObject.layer) && other.gameObject != _LastHitted)
        {
            _LastHitted = other.gameObject;
            other.gameObject.GetComponent<DropMonstre>().LostHealth(_DommageHit,2);
            _NbRebond ++;

            //Rebond

            ZoneEffetEclair otherZoneEffetEclair = other.gameObject.GetComponent<EclairTarget>()._ZoneEffetEclair;
            if(otherZoneEffetEclair._IAProche.Count != 0 && _NbRebond < _NbRebondMax)
            {
                //Calcule de l'ia la plus proche
                GameObject IALaPlusProche = otherZoneEffetEclair._IAProche[0];

                if(otherZoneEffetEclair._IAProche.Count >= 2)
                {
                    for(int i = 0 ; i < otherZoneEffetEclair._IAProche.Count ; i++)
                    {
                        if(IALaPlusProche != null)
                        {
                            if(Vector3.Distance(IALaPlusProche.transform.position, transform.position) > Vector3.Distance(otherZoneEffetEclair._IAProche[i].transform.position, transform.position))
                            {
                                IALaPlusProche = otherZoneEffetEclair._IAProche[i];
                            }
                        }
                    }
                }
                // Change la direction du missile

                if(IALaPlusProche != null)
                {
                    ChangeTarget(IALaPlusProche.transform);
                }
                else
                {
                    Destroy(gameObject);
                }
                
            }

            else
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(_WhatIsWall.Contains(other.gameObject.layer))
        {
            Destroy(gameObject);
        }
    }

    public void ChangeTarget(Transform Target)
    {
        _Rigidbody.velocity = new Vector3 (0,0,0);

        GetComponent<Rigidbody>().AddForce(DirectionTarget(Target) * 600);
    }

    public Vector3 DirectionTarget(Transform Target)
    {
        Vector3 DirectionTarget = Target.position - transform.position;

        return DirectionTarget;
    }


}
