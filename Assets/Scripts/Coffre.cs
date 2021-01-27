using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffre : MonoBehaviour
{
    public LayerMask _WhatIsPlayer;

    public void CoffreOpen()
    {
        Debug.Log("Open Coffre");
        int random = Random.Range(0, GameManager._GameManager._AllCollectibleBonus.Count);
        Instantiate(GameManager._GameManager._AllCollectibleBonus[random], transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("TouchCoffre");
        if(_WhatIsPlayer.Contains(other.gameObject.layer))
        {
            Debug.Log("TouchPlayer");
            movement movementPlayer = other.gameObject.GetComponent<movement>();

            if(movementPlayer.KeyValue > 0)
            {
                movementPlayer.KeyValue--;
                CoffreOpen();
            }
        }
    }
}
