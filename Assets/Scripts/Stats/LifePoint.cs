using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifePoint : MonoBehaviour
{
    public float _Health;
    private float _HealthMax;

    //Brulure
    public int _NbTicBrulure;
    public float _IntervalEntreHitBrulure = 0.5f;
    private float _DommagePerHit;
    private float _TimerBurn;

    //UI
    public Slider _SliderHealthBarre;

    public string scene;

    void Start()
    {

        _HealthMax = _Health;
        SetSlider();
    }

    public void LostHealth(float HealthLose)
    {
        _Health -= HealthLose;
        CheckIfDie();
    }

    public void CheckIfDie()
    {
        SetSlider();
        if(_Health <= 0)
        {
            SceneManager.LoadScene(scene);
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

    public void SetSlider()
    {
        _SliderHealthBarre.maxValue = _HealthMax;
        _SliderHealthBarre.minValue = 0;
        _SliderHealthBarre.value = _Health;
    }
}
