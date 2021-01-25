using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sortie : MonoBehaviour
{
    public LayerMask _WhatIsPlayer;
    private void OnTriggerEnter(Collider other) 
    {
        if(_WhatIsPlayer.Contains(other.gameObject.layer))
        {
            GameManager._GameManager.NextStage();
        }
    }
}
