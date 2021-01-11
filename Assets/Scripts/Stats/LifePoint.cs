using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePoint : MonoBehaviour
{
    public float _Health;
    private float _HealthMax;

    void Start()
    {
        _HealthMax = _Health;
    }

    public void LostHealth(float HealthLose)
    {
        _Health -= HealthLose;

        CheckIfDie();
    }

    public void CheckIfDie()
    {
        if(_Health <= 0)
        {
            Debug.Log("Je meurs");
            Destroy(gameObject);
        }
    }
}
