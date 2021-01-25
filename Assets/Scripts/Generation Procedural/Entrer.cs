using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrer : MonoBehaviour
{
    void Start()
    {
        Vector3 StartPositionPlayer = new Vector3(transform.position.x, GameManager._GameManager._Player.transform.position.y, transform.position.z);
        GameManager._GameManager._Player.transform.position = StartPositionPlayer;

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
