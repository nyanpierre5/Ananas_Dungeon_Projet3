using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRooms : MonoBehaviour
{
    public LayerMask _WhatIsRoom;
    public GenerationProceduralLevel _GenerationProceduralLevel;

    public Transform _ParentOtherRooms;

    void Update()
    {
        Collider[] roomDetection = Physics.OverlapSphere(transform.position, 1 , _WhatIsRoom);
        if(roomDetection.Length == 0 && _GenerationProceduralLevel._StopGeneration == true)
        {
            // Spawn random room
            int rand = Random.Range(0, _GenerationProceduralLevel._Rooms.Count);
            GameObject lastRoomsInstantiate = Instantiate(_GenerationProceduralLevel._Rooms[rand], transform.position, Quaternion.identity);
            lastRoomsInstantiate.transform.parent = _ParentOtherRooms;
            Destroy(gameObject);
        }
        else if(_GenerationProceduralLevel._StopGeneration == true)
        {
            Destroy(gameObject);
        }
        
    }
}
