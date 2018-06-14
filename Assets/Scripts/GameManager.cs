using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject squareBrick;
    public GameObject triangleBrick;
    public int numberOfBricksToStart;
    public int level;


    // Use this for initialization
    void Start()
    {
        level = 1;

        int numberOfBricksCreated = 0;

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            
            

                int brickToCreate = Random.Range(0,3);
                if (brickToCreate == 0)
                {
                    Instantiate(squareBrick, spawnPoints[i].position, Quaternion.identity);
                   
                }
                else if (brickToCreate == 1)
                {
                    Instantiate(triangleBrick, spawnPoints[i].position, Quaternion.identity);
                   
                }
           
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
