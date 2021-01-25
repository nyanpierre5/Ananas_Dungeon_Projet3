using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager _GameManager = null;
    public GameObject _EcranTransition;
    public GameObject _Player;

    public GenerationProceduralLevel _GenerationProceduralLevel;

    public int _Stage = 1;

    public List<GameObject> _AllCollectibleBonus;

    public GameManager GetManager()
    {
        GameManager InstanceGameManager = _GameManager;
        if(InstanceGameManager == null)
        {
            InstanceGameManager = this;
        }
        return InstanceGameManager;
    }
    private void Awake() 
    {
        _GameManager = GetManager();
    }

    public void LaunchTransition(float Duration)
    {
        StartCoroutine(WaitTransition(Duration));
    }
    IEnumerator WaitTransition(float Duration)
    {
        _EcranTransition.SetActive(true);
        _Player.SetActive(false);
        yield return new WaitForSeconds(Duration);
        _Player.SetActive(true);
        _EcranTransition.SetActive(false);
    }

    public void NextStage()
    {
        ClearStage();
        _GenerationProceduralLevel.Init();
        _Stage ++;
    }

    public void ClearStage()
    {
        RootRoom[] _AllStage = FindObjectsOfType<RootRoom>();
        for(int i = 0 ; i < _AllStage.Length ; i++)
        {
            Destroy(_AllStage[i].gameObject);
        }

    }
}
