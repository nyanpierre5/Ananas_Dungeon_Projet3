using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonster : MonoBehaviour
{
    public List<GameObject> _Objects;

    public List<GameObject> _ObjectsCopied;
    public List<GameObject> _Creature;
    public bool _FirstInstantiate = false;
    public int _NbPaternToSpawn;

    public CameraSwapPos _CameraSwapPos;

    private void Start() 
    {
        _ObjectsCopied = new List<GameObject>(_Objects);
    }
    public void Instantiate()
    {
        
        for(int i = 0 ; i < _NbPaternToSpawn; i++)
        {
            int rand = Random.Range(0, _ObjectsCopied.Count);
            GameObject LastInstantiate = Instantiate(_ObjectsCopied[rand], transform.position, Quaternion.identity);
            LastInstantiate.transform.parent = transform;
            _ObjectsCopied.RemoveAt(rand);
            
            SalleCreature LastSalleCreature = LastInstantiate.GetComponent<SalleCreature>();
            for(int j = 0 ; j < LastSalleCreature._AllCreature.Count; j++)
            {
                _Creature.Add(LastSalleCreature._AllCreature[j]);
            }

            _FirstInstantiate = true;
        }
        
    }

    private void Update() 
    {   
        if(_Creature.Count > 0 && _FirstInstantiate == true)
        {
            for(int i = 0 ; i < _Creature.Count ; i++)
            {
                if(_Creature[i] == null)
                {
                    _Creature.RemoveAt(i);
                }
            }
        }
        else
        {
            _CameraSwapPos.EndChallengeRoom();
        }

    }
}
