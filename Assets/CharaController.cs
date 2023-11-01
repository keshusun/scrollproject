using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaController : MonoBehaviour
{
    private Rigidbody2D rigid2D;

    private float velocityX = 5f;

    private float velocityY = 10f;

    public int MaxJumpCount = 2;

    private float jumpCount = 0;


    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputVelocityX = 0;

        float inputVelovityY = 0;

        if(Input.GetKey (KeyCode.LeftArrow))
        {
            inputVelocityX = -this.velocityX;
        }
        if(Input.GetKey (KeyCode.RightArrow))
        {
            inputVelocityX = this.velocityX;
        }
        if(Input.GetKeyDown (KeyCode.UpArrow) && this.jumpCount < MaxJumpCount)
        {
            inputVelovityY = velocityY;
            jumpCount++;
        }
        else
        {
            inputVelovityY = this.rigid2D.velocity.y;
        }
        


        this.rigid2D.velocity = new Vector3(inputVelocityX, inputVelovityY, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EarthTag")
        {
            jumpCount = 0;
        }

        if(collision.gameObject.tag == "SawTag")
        {
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();

            this.gameObject.SetActive(false);
           
            
        }
        
        if(collision.gameObject.tag == "GoalTag")
        {
            GameObject.Find("Canvas").GetComponent<UIController>().Clear();
            this.gameObject.SetActive(false);
        }
    }


}

