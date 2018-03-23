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

    // Use this for initialization
    void Start () {
        Debug.Log("HELLO WORLD");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump")){
            Debug.Log("Jump");            
            PlayerRigidbody.AddForce(new Vector2(0, ForceJump));
            jump = true;
        }
        if (Input.GetButtonDown("Horizontal")){
            Debug.Log("Horizontal");
            run = true;
        }
        if (Input.GetButtonDown("Attack")){
            Debug.Log("Trow");
            attack = true;

        }
        if (Input.GetButtonDown("Slide")){
            Debug.Log("Slide");
            slide = true;

        }
    }
}
