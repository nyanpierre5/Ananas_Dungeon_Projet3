using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrillageScaler : MonoBehaviour
{
    public Vector3 _ScaleGrille;
    private float _pourcentage;
    private bool _Spawned;
    public void Spawn()
    {
        _Spawned = true;
    }
    private void Update() 
    {
        if(_Spawned)
        {
            _pourcentage += Time.deltaTime;
            transform.localScale = Vector3.Lerp(_ScaleGrille, Vector3.one , _pourcentage);

            if( _pourcentage >= 1)
            {
                _Spawned = false;
                _pourcentage = 0;
            }
        }
    }
}
