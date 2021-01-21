using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
    /*
    public InputAction zqsd;
    public InputAction fireAction;
    
    public InputAction mouseshoot;
    */
    public GameObject Fire1;
    public GameObject Thunder1;
    public GameObject Ice1;
    public GameObject Fire2;
    public GameObject Thunder2;
    public GameObject Ice2;
    public GameObject Fire3;
    public GameObject Thunder3;
    public GameObject Ice3;
    public GameObject Fire4;
    public GameObject Thunder4;
    public GameObject Ice4;
    public GameObject Fire5;
    public GameObject Thunder5;
    public GameObject Ice5;




    public GameObject FireSelection;
    public GameObject ThunderSelection;
    public GameObject IceSelection;

    public Text CounterC;
     float CoinValue = 0;

    public Text CounterK;
     float KeyValue = 0;

  

    public float speed;

    public CharacterController controller;

    public Transform bulletset;

    static float Sort = 1;
    static float PowerFeu = 1;
    static float PowerEclair = 1;
    static float PowerGlace = 1;


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

        //Feu
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 1 && PowerFeu == 1)
        {
            GameObject bullet = Instantiate(Fire1, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 600);
        }
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 1 && PowerFeu == 2)
        {
            GameObject bullet = Instantiate(Fire2, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 600);
        }
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 1 && PowerFeu == 3)
        {
            GameObject bullet = Instantiate(Fire3, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 600);
        }
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 1 && PowerFeu == 4)
        {
            GameObject bullet = Instantiate(Fire4, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 600);
        }
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 1 && PowerFeu >= 5)
        {
            GameObject bullet = Instantiate(Fire5, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 600);
        }


        //Eclair
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 2 && PowerEclair == 1)
        {
            GameObject bullet = Instantiate(Thunder1, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 600);
        }
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 2 && PowerEclair == 2)
        {
            GameObject bullet = Instantiate(Thunder2, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 600);
        }
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 2 && PowerEclair == 3)
        {
            GameObject bullet = Instantiate(Thunder3, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 600);
        }
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 2 && PowerEclair == 4)
        {
            GameObject bullet = Instantiate(Thunder4, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 600);

        }
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 2 && PowerEclair == 5)
        {
            GameObject bullet = Instantiate(Thunder5, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 600);
        }


        // Glace
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 3 && PowerGlace == 1)
        {
            GameObject bullet = Instantiate(Ice1, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 600);
        }
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 3 && PowerGlace == 2)
        {
            GameObject bullet = Instantiate(Ice2, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 600);
        }
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 3 && PowerGlace == 3)
        {
            GameObject bullet = Instantiate(Ice3, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 600);
        }
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 3 && PowerGlace == 4)
        {
            GameObject bullet = Instantiate(Ice4, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 600);

        }
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 3 && PowerGlace >= 5)
        {
            GameObject bullet = Instantiate(Ice5, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 600);

        }
  




        //Affichage UI
        if (Sort == 1)
        {
            FireSelection.SetActive(true);
            ThunderSelection.SetActive(false);
            IceSelection.SetActive(false);
        }
        if (Sort == 2)
        {
            FireSelection.SetActive(false);
            ThunderSelection.SetActive(true);
            IceSelection.SetActive(false);
        }
        if (Sort == 3)
        {
            FireSelection.SetActive(false);
            ThunderSelection.SetActive(false);
            IceSelection.SetActive(true);
        }
    


        Move();

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            Sort += 1;
        }
        if (Sort >= 4)
        {
            Sort = 1;
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

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {

            CoinValue += 1;
            CounterC.text = "" + CoinValue;
            Destroy(other.gameObject);
        }

        if (other.tag == "Key")
        {

            KeyValue += 1;
            CounterK.text = "" + KeyValue;
            Destroy(other.gameObject);
        }
        if (other.tag == "UpFire")
        {

            PowerFeu += 1;  
       
            Destroy(other.gameObject);
        }
        if (other.tag == "UpThunder")
        {

            PowerEclair += 1;

            Destroy(other.gameObject);
        }
        if (other.tag == "UpIce")
        {

            PowerGlace += 1;

            Destroy(other.gameObject);
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
