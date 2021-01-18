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
    public GameObject Fire;
    public GameObject Thunder;
    public GameObject Ice;
    public GameObject FireSelection;
    public GameObject ThunderSelection;
    public GameObject IceSelection;



    public float speed;

    public CharacterController controller;

    public Transform bulletset;

    static float power = 1;


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


        if (Input.GetKeyDown(KeyCode.Space) && power == 1)
        {
            GameObject bullet = Instantiate(Fire, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 600);
        }
        if (Input.GetKeyDown(KeyCode.Space) && power == 2)
        {
            GameObject bullet = Instantiate(Thunder, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 600);
        }
        if (Input.GetKeyDown(KeyCode.Space) && power == 3)
        {
            GameObject bullet = Instantiate(Ice, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 600);
        }
        if (power == 1)
        {
            FireSelection.SetActive(true);
            ThunderSelection.SetActive(false);
            IceSelection.SetActive(false);
        }
        if (power == 2)
        {
            FireSelection.SetActive(false);
            ThunderSelection.SetActive(true);
            IceSelection.SetActive(false);
        }
        if (power == 3)
        {
            FireSelection.SetActive(false);
            ThunderSelection.SetActive(false);
            IceSelection.SetActive(true);
        }



        Move();

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            power += 1;
        }
        if (power >= 4)
        {
            power = 1;
        }

        if( Input.GetKeyDown(KeyCode.A))
        {
            float angle = -90;
            RotateY(angle);
        }

        if( Input.GetKeyDown(KeyCode.E))
        {
            float angle = 90;
            RotateY(angle);
        }

    }
     void Move()
    {
        

        float horizontalMove = Input.GetAxis("Horizontal");
        float verticallMove = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(0,0,1) * verticallMove + new Vector3(1,0,0) * horizontalMove;
        controller.Move(speed * Time.deltaTime * move);
    }

    public void RotateY(float angleY)
    {
        transform.Rotate(0, angleY, 0, Space.Self);
    }


    







}
