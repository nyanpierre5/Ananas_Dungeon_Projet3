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

    public Animator anim;

    bool CanShoot;

    public AudioSource Pickup;


    public GameObject FireSelection;
    public GameObject ThunderSelection;
    public GameObject IceSelection;

    public Text CounterC;
     float CoinValue = 0;

    public Text CounterK;
    public float KeyValue = 0;

    public Text FireLvl;
    public Text ThunderLvl;
    public Text IceLvl;
    float FireLVlValue = 1;
    float ThunderLVlValue = 1;
    float IceLVlValue = 1;

    public float speed;

    public CharacterController controller;

    public Transform bulletset;

    static float Sort = 1;
    static float PowerFeu = 1;
    static float PowerEclair = 1;
    static float PowerGlace = 1;


    //Orientation
    public float MyRotate = 0;

    public float MyHauteur = 1.88f;

    void Start()
    {
        controller = GetComponent<CharacterController>();

        FireLvl.text = "" + FireLVlValue;
        ThunderLvl.text = "" + ThunderLVlValue;
        IceLvl.text = "" + IceLVlValue;

        CanShoot = true;

        
    }
    private void LateUpdate() 
    {
        Vector3 AjustHauteur = transform.position;
        AjustHauteur.y = MyHauteur;
        transform.position = AjustHauteur;
    }

    void Update()
    {

        //Feu
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 1 && PowerFeu == 1 && CanShoot == true)
        {
            GameObject bullet = Instantiate(Fire1, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 400);

         

            StartCoroutine("HaveShoot");
            StartCoroutine("ShootFire");
        }
     
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 1 && PowerFeu == 2 && CanShoot == true)
        {
            GameObject bullet = Instantiate(Fire2, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 400);
     
            StartCoroutine("HaveShoot");
            StartCoroutine("ShootFire");
        }
     
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 1 && PowerFeu == 3 && CanShoot == true)
        {
            GameObject bullet = Instantiate(Fire3, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 400);
    
            StartCoroutine("HaveShoot");
            StartCoroutine("ShootFire");
        }
    
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 1 && PowerFeu == 4 && CanShoot == true)
        {
            GameObject bullet = Instantiate(Fire4, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 400);
    
            StartCoroutine("HaveShoot");
            StartCoroutine("ShootFire");
        }
     
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 1 && PowerFeu >= 5 && CanShoot == true)
        {
            GameObject bullet = Instantiate(Fire5, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 400);

            StartCoroutine("HaveShoot");
            StartCoroutine("ShootFire");
        }
     


        //Eclair
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 2 && PowerEclair == 1 && CanShoot == true)
        {
            GameObject bullet = Instantiate(Thunder1, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 400);

       
            StartCoroutine("HaveShoot");
            StartCoroutine("ShootThunder");
        }

        if (Input.GetKeyDown(KeyCode.Space) && Sort == 2 && PowerEclair == 2 && CanShoot == true)
        {
            GameObject bullet = Instantiate(Thunder2, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 400);
         
            StartCoroutine("HaveShoot");
            StartCoroutine("ShootThunder");
        }

      
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 2 && PowerEclair == 3 && CanShoot == true)
        {
            GameObject bullet = Instantiate(Thunder3, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 400);
         
            StartCoroutine("HaveShoot");
            StartCoroutine("ShootThunder");
        }

     
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 2 && PowerEclair == 4 && CanShoot == true)
        {
            GameObject bullet = Instantiate(Thunder4, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 400);

          
            StartCoroutine("HaveShoot");
            StartCoroutine("ShootThunder");
        }

   
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 2 && PowerEclair == 5 && CanShoot == true)
        {
            GameObject bullet = Instantiate(Thunder5, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 400);
           
            StartCoroutine("HaveShoot");
            StartCoroutine("ShootThunder");
        }

   


        // Glace
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 3 && PowerGlace == 1 && CanShoot == true)
        {
            GameObject bullet = Instantiate(Ice1, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 400);

       
            StartCoroutine("HaveShoot");
            StartCoroutine("ShootIce");
        }
     
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 3 && PowerGlace == 2 && CanShoot == true)
        {
            GameObject bullet = Instantiate(Ice2, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 400);
       
            StartCoroutine("HaveShoot");
            StartCoroutine("ShootIce");
        }
     
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 3 && PowerGlace == 3 && CanShoot == true)
        {
            GameObject bullet = Instantiate(Ice3, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 400);
      
            StartCoroutine("HaveShoot");
            StartCoroutine("ShootIce");
        }
      
        
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 3 && PowerGlace == 4 && CanShoot == true)
        {
            GameObject bullet = Instantiate(Ice4, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 400);

         
            StartCoroutine("HaveShoot");
            StartCoroutine("ShootIce");
        }
      
        if (Input.GetKeyDown(KeyCode.Space) && Sort == 3 && PowerGlace >= 5 && CanShoot == true)
        {
            GameObject bullet = Instantiate(Ice5, bulletset.transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 400);

            StartCoroutine("HaveShoot");
            StartCoroutine("ShootIce");
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

        if( Input.GetKeyDown(KeyCode.UpArrow))
        {
            RotateY(0 - MyRotate);
            MyRotate = 0;
        }

        if( Input.GetKeyDown(KeyCode.DownArrow))
        {
            RotateY(180 - MyRotate);
            MyRotate = 180;
        }
        if( Input.GetKeyDown(KeyCode.LeftArrow))
        {
            RotateY(-90 - MyRotate);
            MyRotate = -90;
        }
        if( Input.GetKeyDown(KeyCode.RightArrow))
        {
            RotateY(90 - MyRotate);
            MyRotate = 90;
        }


        if (controller.velocity.x == 0 && controller.velocity.y == 0 && controller.velocity.z == 0)
        {
            anim.SetBool("isWalking", false);
        }
        else
        {
            anim.SetBool("isWalking", true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            Pickup.Play();
            CoinValue += 1;
            CounterC.text = "" + CoinValue;
            Destroy(other.gameObject);
        }

        if (other.tag == "Key")
        {
            Pickup.Play();
            KeyValue += 1;
            CounterK.text = "" + KeyValue;
            Destroy(other.gameObject);
        }
        if (other.tag == "UpFire" && FireLVlValue <=4 )
        {
            Pickup.Play();
            FireLVlValue += 1;
            FireLvl.text = "" + FireLVlValue;
            PowerFeu += 1;  
       
            Destroy(other.gameObject);
        }
        if (other.tag == "UpThunder" && ThunderLVlValue <= 4)
        {
            Pickup.Play();
            ThunderLVlValue += 1;
            ThunderLvl.text = "" + ThunderLVlValue;
            PowerEclair += 1;

            Destroy(other.gameObject);
        }
        if (other.tag == "UpIce" && IceLVlValue <= 4)
        {
            Pickup.Play();
            IceLVlValue += 1;
            IceLvl.text = "" + IceLVlValue;
            PowerGlace += 1;

            Destroy(other.gameObject);
        }
    }

    void Move()
    {
        Vector3 move = new Vector3(0,0,0);

        if(Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if(Input.GetKey(KeyCode.Z))
            {
                move.z = 1;
                if(Input.GetKey(KeyCode.S))
                {
                    move.z = 0;
                }
            }

            if(Input.GetKey(KeyCode.S))
            {
                move.z = -1;
                if(Input.GetKey(KeyCode.Z))
                {
                    move.z = 0;
                }
            }

            if(Input.GetKey(KeyCode.Q))
            {
                move.x = -1;
                if(Input.GetKey(KeyCode.D))
                {
                    move.x = 0;
                }
            }

            if(Input.GetKey(KeyCode.D))
            {

                move.x = 1;
                if(Input.GetKey(KeyCode.Q))
                {
                    move.x = 0;
                }
            }
        }

        move = move.normalized;
        controller.Move(speed * Time.deltaTime * move);

    }

    public void RotateY(float angleY)
    {
        transform.Rotate(0, angleY, 0, Space.Self);
    }



    private IEnumerator HaveShoot()
    {

        CanShoot = false;
        yield return new WaitForSeconds(1.2f);


        CanShoot = true;

    }

    private IEnumerator ShootFire()
    {

        anim.SetBool("fire", true);
        yield return new WaitForSeconds(0.5f);


        anim.SetBool("fire", false);

    }
    private IEnumerator ShootThunder()
    {

        anim.SetBool("thunder", true);

        yield return new WaitForSeconds(0.5f);


        anim.SetBool("thunder", false);

    }
    private IEnumerator ShootIce()
    {

        anim.SetBool("Ice", true);
        yield return new WaitForSeconds(0.5f);


        anim.SetBool("Ice", false);

    }
}
