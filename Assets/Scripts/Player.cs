using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour {

    int vidas;
    public Text vidaText; 
    int score;
    public Text scoreText;
    public Transform Respawn;
    public Transform DeathZone;
    private bool Death = false;
    public GameObject flipper1, flipper2;
    public Text gameover;
    private static Player instance;
    public static Player Instance
    {
        get { return instance; }
    }
    

	void Start ()
    {
        gameover.enabled = false;
        vidas = 3;
        score = 0;
        SetCountText();
	}
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Muerte")
        {
            gameObject.transform.position = Respawn.position;
            vidas = vidas - 1;
            SetCountText();
            if (vidas == 0)
            {
                gameObject.transform.position = DeathZone.position;
                Death = true;
                GameOver();
            }
            
        }
        if (collision.gameObject.tag == "Bumpers")
        {
            score = score + 200;
            SetCountText();
            if (score % 2000 == 0)
            {
                vidas = vidas + 1;
                SetCountText();
            }
        }
    }

    void SetCountText()
    {
        vidaText.text = "Vidas: " + vidas.ToString();
        scoreText.text = "Score: " + score.ToString();
    }
    void GameOver()
    {
        if (Death == true)
        {
            flipper1.SetActive(false);
            flipper2.SetActive(false);
            gameover.enabled = true;   
        }
    }
    public void Combo()
    {
        score = score + 1000;
        SetCountText();
        
    }
}
