using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{

    public InputAction zqsd;
    public InputAction fireAction;
    public CharacterController controller;
    public InputAction mouseshoot;

    public GameObject projectile;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void OnEnable()
    {
        zqsd.Enable();
        fireAction.Enable();
        mouseshoot.Enable();
    }
    void OnDisable()
    {
        zqsd.Disable();
        fireAction.Disable();
        mouseshoot.Disable();
    }
    // Update is called once per frame
    void Update()
    {

        Vector2 inputVector = zqsd.ReadValue<Vector2>();
        Vector3 finalVector = new Vector3();

        finalVector.x = inputVector.x;
        finalVector.z = inputVector.y;
        controller.Move(finalVector * Time.deltaTime * 5f);

        if (fireAction.triggered)
        {
          GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 600);
        }
       

    }

    

   
}
