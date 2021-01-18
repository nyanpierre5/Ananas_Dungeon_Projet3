using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneEffetEclair : MonoBehaviour
{
    public GameObject _MyParent;
    public List<GameObject> _IAProche;
    public LayerMask _WhatIsIA;

    private void OnTriggerEnter(Collider other) 
    {
        if(_WhatIsIA.Contains(other.gameObject.layer))
        {
            AddList(other.gameObject);

            RemoveMeIntoList();
        }
    }
    private void OnTriggerExit(Collider other) 
    {
        if(_WhatIsIA.Contains(other.gameObject.layer))
        {
            RemoveList(other.gameObject);

            RemoveMeIntoList();
        }
    }

    public void RemoveMeIntoList()
    {
        if(_IAProche.Count != 0)
        {
            for(int i = 0 ; i < _IAProche.Count ; i ++)
            {
                if(_IAProche[i] == _MyParent)
                {
                    _IAProche.Remove(_MyParent);
                }
            }
        }
    }

    public void AddList(GameObject WhoAdd)
    {
        bool CanAdd = true;

        if(_IAProche.Count != 0)
        {
            for(int i = 0 ; i < _IAProche.Count ; i ++)
            {
                if(_IAProche[i] == WhoAdd)
                {
                    CanAdd = false;
                }
            }
        }

        if(CanAdd)
        {
            _IAProche.Add(WhoAdd);
        }
    }

    public void RemoveList(GameObject WhoRemove)
    {
        bool CanRemove = false;

        if(_IAProche.Count != 0)
        {
            for(int i = 0 ; i < _IAProche.Count ; i ++)
            {
                if(_IAProche[i] == WhoRemove)
                {
                    CanRemove = true;
                }
            }
        }

        if(CanRemove)
        {
            _IAProche.Remove(WhoRemove);
        }
    }
}
