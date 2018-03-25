using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Animator     anime;
    public Rigidbody2D  PlayerRigidbody;

    public int          ForceJump;
    public bool         jump;
    public bool         slide;
    public bool         attack;
    public bool         run;

    //VERIFIcA CHAO
    public bool         Grounded;
    public Transform    GroundCheck;  
    public LayerMask    whatIsGround;

    //SLIDE 
    public float timeTemp;
    public float slideTemp; 
   


    // Use this for initialization
    void Start () {
        Debug.Log("HELLO WORLD");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump") && Grounded==true){
            Debug.Log("Jump");            
            PlayerRigidbody.AddForce(new Vector2(0, ForceJump));
            slide = false;
        }
        if (Input.GetButtonDown("Horizontal")){
            Debug.Log("Horizontal");
            run = true;
        }
        if (Input.GetButtonDown("Attack")){
            Debug.Log("Trow");
            attack = true;
        }
        if (Input.GetButtonDown("Slide") && Grounded==true){
            Debug.Log("Slide");
            slide = true;
            timeTemp = 0;

        }

        Grounded = Physics2D.OverlapCircle(GroundCheck.position, 0.2f, whatIsGround);
        
        if(slide==true){
            timeTemp += Time.deltaTime;
            if(timeTemp >= slideTemp){
                slide = false;
            }
        }

        anime.SetBool("jump", !Grounded);
        anime.SetBool("slide", slide);
        anime.SetBool("trow", attack);
        anime.SetBool("run", run);


    }
}
