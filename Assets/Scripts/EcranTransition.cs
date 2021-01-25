using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EcranTransition : MonoBehaviour
{
    public Text _TextShowStage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        _TextShowStage.text = "Stage " + GameManager._GameManager._Stage + " :";
    }
}
