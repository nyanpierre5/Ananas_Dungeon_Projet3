using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomRooms : MonoBehaviour
{
    public List<GameObject> _Objects;
    public int _NbRoomGreatPath = 999999; // 0 = Début chemin // Doit Commencer à un nb abérant
    public int _NbOfRoomsGreatPath; // Commence à 0 (Donc 9 = 10 salle au total)
    public bool _IsGreatPath;

    public GameObject _GameObjectEntre;
    public GameObject _GameObjectSortie;

    private bool _FirstSpawn;

    private GameObject _Room;
    

    void Start()
    {
        int rand = Random.Range(0, _Objects.Count);
        _Room = Instantiate(_Objects[rand], transform.position, Quaternion.identity);
        _Room.transform.parent = transform;
    }

    private void Update() 
    {
        if(_NbRoomGreatPath == 0 && _FirstSpawn == false)
        {
            GameObject _LastInstantiate = Instantiate(_GameObjectEntre, transform.position , Quaternion.identity);
            _LastInstantiate.transform.parent = transform;
            _FirstSpawn = true;

            SpawnMonster MySpawnMonster = _Room.GetComponentInChildren<SpawnMonster>();
            Destroy(MySpawnMonster);
        }

        if(_NbRoomGreatPath == _NbOfRoomsGreatPath && _FirstSpawn == false)
        {
            GameObject _LastInstantiate = Instantiate(_GameObjectSortie, transform.position , Quaternion.identity);
            _LastInstantiate.transform.parent = transform;
            _FirstSpawn = true;

            SpawnMonster MySpawnMonster = _Room.GetComponentInChildren<SpawnMonster>();
            Destroy(MySpawnMonster);
        }
    }

}
