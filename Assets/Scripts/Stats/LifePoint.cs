using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePoint : MonoBehaviour
{
    public float _Health;
    private float _HealthMax;

    //Brulure
    public int _NbTicBrulure;
    public float _IntervalEntreHitBrulure = 0.5f;
    private float _DommagePerHit;
    private float _TimerBurn;

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

    private void Update() 
    {

        if(_NbTicBrulure > 0)
        {
            _TimerBurn += Time.deltaTime;
            if(_TimerBurn >= _IntervalEntreHitBrulure)
            {
                _Health -= _DommagePerHit;
                _TimerBurn = 0;
                _NbTicBrulure--;
                CheckIfDie();
            }
        }

    }

    public void OnBurn(int _NbTicBurn, float _DegatPerHit)
    {
        _NbTicBrulure += _NbTicBurn;
        _DommagePerHit = _DegatPerHit;
    }
}
