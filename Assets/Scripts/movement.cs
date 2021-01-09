using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{

    public InputAction zqsd;
    public CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void OnEnable()
    {
        zqsd.Enable();
    }
    void OnDisable()
    {
        zqsd.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = zqsd.ReadValue<Vector2>();
        Vector3 finalVector = new Vector3();

        finalVector.x = inputVector.x;
        finalVector.z = inputVector.y;
        controller.Move(finalVector * Time.deltaTime * 5f);
    }

   
}
