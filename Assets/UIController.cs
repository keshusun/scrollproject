using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    private GameObject gameOverText;

    private GameObject timeText;

    private GameObject clearText;

    private float time = 0;

    private bool isGameOver = false;

    private bool isClear = false;

    // Start is called before the first frame update
    void Start()
    {
        this.gameOverText = GameObject.Find("GameOver");

        this.timeText = GameObject.Find("Time");

        this.clearText = GameObject.Find("Clear");
    }

    // Update is called once per frame
    void Update()
    {
        if(this.isGameOver == false && this.isClear == false)
        {
            this.time = Time.time;

            this.timeText.GetComponent<Text>().text = "Time " + this.time;
        }

        if(this.isGameOver == true || this.isClear == true)
        {

            if(Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    public void GameOver()
    {
        this.gameOverText.GetComponent<Text>().text = "Game Over";
        this.isGameOver = true;
    }

    public void Clear()
    {
        this.clearText.GetComponent<Text>().text = "  Game Clear !!";
        this.isClear = true;
    }
}
