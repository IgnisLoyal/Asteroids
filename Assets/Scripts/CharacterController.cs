using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{   

    [SerializeField]
    private int rotationSpeed;
    public GameObject player;
    public GameObject shootOrigin;
    public GameObject bullet;
    private float nextShot = 0.15f;
    [SerializeField]
    private float fireDelay = 0.5f;
    [SerializeField]
    private float velocity = 10f;
    private float maxVelocity;
    
    //asteroid variables


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {

            transform.Rotate(0, 0, (rotationSpeed * -1) * Time.deltaTime);
        }
        
        // time.time see how many seconds has passed since the beginning of the game
        //next shot is a variable that will determine how long the game was running, also will determine if the player can shoot again (if 0.15 seconds have passed)
        if (Input.GetKey(KeyCode.Space) && Time.time > nextShot)
        {       
                Instantiate(bullet, bullet.transform.position = shootOrigin.transform.position, bullet.transform.rotation = shootOrigin.transform.rotation);
                nextShot = Time.time + fireDelay;             
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, velocity * Time.deltaTime, 0);
            /*if( velocity >= maxVelocity)
            {
                velocity = maxVelocity;
            }*/
        }

        
    }



}