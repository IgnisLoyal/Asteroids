using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniAsteroidBehavior : MonoBehaviour
{
    public GameObject asteroid;
    [SerializeField]
    private int size;
    [SerializeField]
    private int velocity;
    [SerializeField]
    private int life;
    [SerializeField]
    private int xScale;
    // Start is called before the first frame update
    void Start()
    {   
        //sets size on a certain range
        xScale = Random.Range(1, 2);
        asteroid.transform.localScale = new Vector3(xScale, xScale, xScale);
        //set asteroid velocity between 1 to 7s
        velocity = Random.Range(1, 7);
        //spawns asteroids in a random rotation
        transform.Rotate(0, 0, Random.Range(0.0f , 360.0f));
        //Sets life on a certain range
        life = Random.Range(1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        asteroidsVelocity();
        if(life <= 0)
        {
            Destroy(asteroid, 0.0f);
        }
    }

        private void asteroidsVelocity()
    {
        transform.Translate(velocity * Time.deltaTime, 0 ,0);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Bullet")
        {
            life --;
        }
    }
}
