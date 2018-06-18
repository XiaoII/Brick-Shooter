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
    public List<GameObject> bricksInScene;
    public ObjectPool objectPool;

    // Use this for initialization
    void Start()
    {
        objectPool = FindObjectOfType<ObjectPool>();

        level = 1;

        int numberOfBricksCreated = 0;

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            
            

                int brickToCreate = Random.Range(0,3);
                if (brickToCreate == 0)
                {
                    bricksInScene.Add(Instantiate(squareBrick, spawnPoints[i].position, Quaternion.identity));
                   
                }
                else if (brickToCreate == 1)
                {
                    bricksInScene.Add(Instantiate(triangleBrick, spawnPoints[i].position, Quaternion.identity));
                   
                }
           
        }
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void PlaceBricks()
    {
        level++;
        foreach (Transform position in spawnPoints)
        {

            int brickToCreate = Random.Range(0, 3);
            if (brickToCreate == 0)
            {
                GameObject brick = objectPool.GetPooledObject("Square Brick");
                bricksInScene.Add(brick);
                if (brick != null)
                {
                    brick.transform.position = position.position;
                    brick.transform.rotation = Quaternion.identity;
                    brick.SetActive(true);
                }

            }
            else if (brickToCreate == 1)
            {
                GameObject brick = objectPool.GetPooledObject("Triangle Brick");
                bricksInScene.Add(brick);
                if (brick != null)
                {
                    brick.transform.position = position.position;
                    brick.transform.rotation = Quaternion.identity;
                    brick.SetActive(true);
                }

            }
        }
    }
}
