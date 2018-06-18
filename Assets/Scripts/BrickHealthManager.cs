using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrickHealthManager : MonoBehaviour {

    public int brickHealth;
    private Text brickHealthText;
    private GameManager gameManager;

	// Use this for initialization
	void Start () {
        gameManager = FindObjectOfType<GameManager>();
        brickHealth = gameManager.level;
        brickHealthText = GetComponentInChildren<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        brickHealthText.text = "" + brickHealth;
        if (brickHealth <= 0)
        {
            this.gameObject.SetActive(false);
        }
	}

    void TakeDamage(int damageToTake)
    {
        brickHealth -= damageToTake;
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            TakeDamage(1);
        }
    }

}
