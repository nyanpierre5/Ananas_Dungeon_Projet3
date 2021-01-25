using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerationProceduralLevel : MonoBehaviour
{
    public List<Vector3> _StartingPositions;
    public List<GameObject> _Rooms; // Index 0 --> LR, Index 1 --> LRB, Index 2 --> LRT, Index 3 --> LRTB

    private int _Direction;
    public float _MoveAmountX;
    public float _MoveAmountZ;

    private float _TimeBtwRoom;
    public float _StartTimeBtwRoom = 0.25f;

    public float _MinX;
    public float _MaxX;
    public float _MinZ;

    public bool _StopGeneration = false;

    public LayerMask _LayerMaskRoom;

    public int _DownCounter;

    public Transform _ParentGreatPath;


    public List<GameObject> _ListGameObjectGreatPath;
    public List<GameObject> _ListGameObjectGreathPathCorrect; // Comme _ListGameObjectGreatPath sans les trous des salles détruites

    public List<GameObject> _AllSpawnRooms;
    private void Start() 
    {
        Init();
    }

    public void Init()
    {
        _ListGameObjectGreatPath.Clear();
        _ListGameObjectGreathPathCorrect.Clear();

        _StopGeneration = false;

        for(int i = 0 ; i < _AllSpawnRooms.Count ; i++)
        {
            _AllSpawnRooms[i].SetActive(true);
        }

        GameManager._GameManager.LaunchTransition(10);
        GenerateFirstStage();
    }

    private void Update() 
    {
        if(_TimeBtwRoom <= 0 && _StopGeneration == false)
        {
            Move();
            _TimeBtwRoom = _StartTimeBtwRoom;
        }
        else
        {
            _TimeBtwRoom -= Time.deltaTime;
        }
    }

    public void GenerateFirstStage()
    {
        int randomStartingPosition = Random.Range(0, _StartingPositions.Count);
        transform.position = _StartingPositions[randomStartingPosition];
        GameObject FirstRoomInstantiate = Instantiate(_Rooms[0], transform.position, Quaternion.identity);
        FirstRoomInstantiate.transform.parent = _ParentGreatPath;
        _ListGameObjectGreatPath.Add(FirstRoomInstantiate);
        _Direction = Random.Range(1,6);

    }

    private void Move()
    {
        if(_Direction == 1 || _Direction == 2) // Right
        {
            if(transform.position.x < _MaxX)
            {
                _DownCounter = 0 ;

                Vector3 newPos = new Vector3(transform.position.x + _MoveAmountX, transform.position.y,transform.position.z);
                transform.position = newPos;

                int rand = Random.Range(0, _Rooms.Count);
                GameObject LastRoomInstantiate = Instantiate(_Rooms[rand], transform.position, Quaternion.identity);
                LastRoomInstantiate.transform.parent = _ParentGreatPath;
                _ListGameObjectGreatPath.Add(LastRoomInstantiate);

                _Direction = Random.Range(1, 6);

                if(_Direction == 3)
                {
                    _Direction = 2;
                }
                else if(_Direction == 4)
                {
                    _Direction = 5;
                }
            }
            else
            {
                _Direction = 5;
            }

        }
        else if(_Direction == 3 ||_Direction == 4) //Left
        {
            if(transform.position.x > _MinX)
            {
                _DownCounter = 0 ;

                Vector3 newPos = new Vector3(transform.position.x - _MoveAmountX, transform.position.y,transform.position.z);
                transform.position = newPos;
                
                int rand = Random.Range(0, _Rooms.Count);
                GameObject LastRoomInstantiate = Instantiate(_Rooms[rand], transform.position, Quaternion.identity);
                LastRoomInstantiate.transform.parent = _ParentGreatPath;
                _ListGameObjectGreatPath.Add(LastRoomInstantiate);

                _Direction = Random.Range(3, 6);

            }
            else
            {
                _Direction = 5;
            }

        }
        else if(_Direction == 5)
        {
            _DownCounter ++;

            if(transform.position.z > _MinZ)
            {
                Collider[] roomDetection = Physics.OverlapSphere(transform.position, 1 , _LayerMaskRoom);

                for(int i = 0; i <roomDetection.Length ; i++)
                {
                    if(roomDetection[0].GetComponent<RoomType>()._Type != 1 && roomDetection[0].GetComponent<RoomType>()._Type != 3)
                    {

                        if(_DownCounter >=2)
                        {
                            roomDetection[0].GetComponent<RoomType>().RoomDestroy();
                            GameObject LastRoomInstantiate = Instantiate(_Rooms[3], transform.position,Quaternion.identity);
                            LastRoomInstantiate.transform.parent = _ParentGreatPath;
                            _ListGameObjectGreatPath.Add(LastRoomInstantiate);
                        }
                        
                        
                        else
                        {
                            roomDetection[0].GetComponent<RoomType>().RoomDestroy();

                            int randBottomRoom = Random.Range(1,4);
                            if(randBottomRoom == 2)
                            {
                                randBottomRoom = 1;
                            }

                            GameObject LastRoomInstantiate = Instantiate(_Rooms[randBottomRoom], transform.position,Quaternion.identity);
                            LastRoomInstantiate.transform.parent = _ParentGreatPath;
                            _ListGameObjectGreatPath.Add(LastRoomInstantiate);
                        }
                        
                    }
                }

                Vector3 newPos = new Vector3(transform.position.x, transform.position.y,transform.position.z - _MoveAmountZ);
                transform.position = newPos;

                int rand = Random.Range(2, 4);
                GameObject LastRoomInstantiated = Instantiate(_Rooms[rand], transform.position, Quaternion.identity);
                LastRoomInstantiated.transform.parent = _ParentGreatPath;
                _ListGameObjectGreatPath.Add(LastRoomInstantiated);

                _Direction = Random.Range(1, 6);
            }
            else
            {
                // Stop la génération;
                _StopGeneration = true;


                for(int i = 0 ; i < _ListGameObjectGreatPath.Count; i++)
                {
                    if(_ListGameObjectGreatPath[i] != null)
                    {
                        _ListGameObjectGreathPathCorrect.Add(_ListGameObjectGreatPath[i]);
                    }
                }

                //Numerote les salles du Script "SpawnObject" 
                for(int i = 0 ; i < _ListGameObjectGreathPathCorrect.Count; i ++)
                {
                    _ListGameObjectGreathPathCorrect[i].GetComponent<SpawnRandomRooms>()._NbRoomGreatPath = i;
                    _ListGameObjectGreathPathCorrect[i].GetComponent<SpawnRandomRooms>()._NbOfRoomsGreatPath = _ListGameObjectGreathPathCorrect.Count - 1;
                    _ListGameObjectGreathPathCorrect[i].GetComponent<SpawnRandomRooms>()._IsGreatPath = true;
                }
            }

        }


    }
}
