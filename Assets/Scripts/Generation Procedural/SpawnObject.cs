using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public List<GameObject> _Objects;
    public int _NbRoomGreatPath; // 0 = Début
    public int _NbOfRoomsGreatPath; // Commence à 0 (Donc 9 = 10 salle au total)
    public bool _IsGreatPath;

    void Start()
    {
        int rand = Random.Range(0, _Objects.Count);
        GameObject LastInstantiate = Instantiate(_Objects[rand], transform.position, Quaternion.identity);
        LastInstantiate.transform.parent = transform;
    }


}
