using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class levelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject asteroid;
    public GameObject bullet;
    
    public TextAsset scoreCounter;
    [SerializeField]
    public int spawnNumber;
    void Start()
    {
        spawnNumber = Random.Range(1, 3);
        //scoreCounter.ToString = "0";
        spawnAsteroids();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    private void spawnAsteroids()
    {
        for( int i = 0; i < spawnNumber; i++)
        {
        var position = new Vector3(Random.Range(-8.0f, 8.0f), Random.Range(-4.5f, 4.5f),0);
        Instantiate(asteroid, position, Quaternion.identity);
        }
    }
}
