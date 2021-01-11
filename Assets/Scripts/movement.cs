using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{
    /*
    public InputAction zqsd;
    public InputAction fireAction;
    
    public InputAction mouseshoot;
    */
    public GameObject projectile;

    public float speed;

    public CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    /*
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
    */
    // Update is called once per frame
    void Update()
    {
        /*
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
        */
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 600);
        }
        Move();
    }
     void Move()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticallMove = Input.GetAxis("Vertical");


        Vector3 move = transform.forward * verticallMove + transform.right * horizontalMove;
        controller.Move(speed * Time.deltaTime * move);
    }






}
