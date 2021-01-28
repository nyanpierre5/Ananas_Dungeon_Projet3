using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropMonstre : MonoBehaviour
{
    public float _Health;
    private float _HealthMax;

    public GameObject ImmuneParticle;
    public GameObject FireParticle;

    //Brulure
    public int _NbTicBrulure;
    public float _IntervalEntreHitBrulure = 0.5f;
    private float _DommagePerHit;
    private float _TimerBurn;

    //Chance Loot Bonus
    public float _TauxDropBonusEnPourcentage;

    //UI
    public Slider _SliderHealthBarre;

    //Immunity AT
    public int _ImmunityAtWhat; // 1 = fire // 2 = Eclair // 3 = Ice

    public AudioSource Dmonster;

    void Start()
    {
        Dmonster = GameObject.Find("DeathSound").GetComponent<AudioSource>();
        _Health = _Health + (_Health * 0.2f) * GameManager._GameManager._Stage;
        _HealthMax = _Health;
        SetSlider();
    }

    public void LostHealth(float HealthLose , int TypeAttack)
    {
        if(TypeAttack != _ImmunityAtWhat)
        {
            _Health -= HealthLose;
        }
        if (TypeAttack == _ImmunityAtWhat)
        {
            StartCoroutine("Shield");
        }

        if (TypeAttack != _ImmunityAtWhat && TypeAttack == 1)
        {
            StartCoroutine("Burn");
        }

        CheckIfDie();
    }

    public void CheckIfDie()
    {
        SetSlider();
        if(_Health <= 0)
        {
            Dmonster.Play();
            Looting();
            Destroy(gameObject);
        }
    }

    private void Update() 
    {

        if(_NbTicBrulure > 0 && _ImmunityAtWhat != 1)
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

    public void Looting()
    {
        int rand = Random.Range(0,101);
        if(rand >= 100 - _TauxDropBonusEnPourcentage)
        {
            Debug.Log("Loot");
            int random = Random.Range(0, GameManager._GameManager._AllCollectibleBonus.Count);
            Instantiate(GameManager._GameManager._AllCollectibleBonus[random], transform.position, Quaternion.identity);
        }
    }

    public void SetSlider()
    {
        _SliderHealthBarre.maxValue = _HealthMax;
        _SliderHealthBarre.minValue = 0;
        _SliderHealthBarre.value = _Health;
    }

    private IEnumerator Shield()
    {

        ImmuneParticle.SetActive(true);
        yield return new WaitForSeconds(0.7f);

        ImmuneParticle.SetActive(false);

    }
    private IEnumerator Burn()
    {

        FireParticle.SetActive(true);
        yield return new WaitForSeconds(0.7f);

        FireParticle.SetActive(false);

    }
}
