using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBehaviour : MonoBehaviour
{

    public GameObject bullet;
    public GameObject spawner;
    [SerializeField]
    private int velocity;

    [SerializeField]
    private int destroyTiming = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //will transport the game object in a certain velocity and on the next line will destroy the same game objects after certain amout of seconds
        transform.Translate(0, velocity * Time.deltaTime, 0);
        Destroy(bullet, destroyTiming);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Asteroid")
        {
            Destroy(bullet, 0);
        }   
    }

}
