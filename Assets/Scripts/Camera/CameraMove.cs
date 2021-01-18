using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private float _LerpMove;
    public float _TimeTransition;
    public AnimationCurve _Curve;

    public Vector3 _Target;
    public Vector3 _PosInitial;

    private void Start() 
    {
        _PosInitial = transform.position;
    }

    void Update()
    {
        _LerpMove += Time.deltaTime / _TimeTransition;

        transform.position = Vector3.Lerp(_PosInitial , _Target, _Curve.Evaluate(_LerpMove));
    }

    public void MoveAtPos(Vector3 NewPos)
    {
        _PosInitial = transform.position;
        _Target = NewPos;

        _LerpMove = 0;
    }
}
