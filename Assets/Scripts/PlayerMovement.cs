using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public bool isDead;
    [Header("RunIndex")]
    [SerializeField] Vector2 moveInput;
    [SerializeField] float runSpeed = 5f;
    [SerializeField] float jumpHeight = 20f;

    Rigidbody2D myRigidbody;
    Animator myAnimator;
    BoxCollider2D myFeet;
    //PlayerCollision playerCollision;
    public static PlayerMovement instance;

    [Header("Timer")]
    [SerializeField] float timer = 0;
    [SerializeField] float timeDelay = 0.2f;
    void Start()
    {
        instance = this;
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myFeet = GetComponent<BoxCollider2D>();
        //playerCollision = GetComponent<PlayerCollision>();
    }
    void Update()
    {
        if(isDead) return;
        Run();
        FlipPlayer();
    }
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
        void OnJump(InputValue value)
    {
        if (isDead) return;
        if (!myFeet.IsTouchingLayers(LayerMask.GetMask("Ground"))) {
            return;
        }
        if (value.isPressed)
        {
           AudioPlayer.instance.JumpSound();
            myRigidbody.velocity += new Vector2(0, jumpHeight);
        }
    }
    void Run()
    {
        Vector2 playerMove = new Vector2(moveInput.x * runSpeed, myRigidbody.velocity.y);
        myRigidbody.velocity = playerMove;

        bool playerHasHorizontal = Mathf.Abs(myRigidbody.velocity.x) > Mathf.Epsilon;

        if(playerHasHorizontal)
        {
            RunSoundTimer();
        }
        myAnimator.SetBool("IsRunning", playerHasHorizontal);
    }
    void FlipPlayer()
    {
        bool playerHasHorizontal = Mathf.Abs(myRigidbody.velocity.x) > Mathf.Epsilon;
        if(playerHasHorizontal)
        {
            transform.localScale = new Vector2(Mathf.Sign(myRigidbody.velocity.x), 1);
        }
    }
    public void RunSoundTimer()
    {
        timer += Time.deltaTime;
        if (timer < timeDelay) return;
        timer = 0f;
        AudioPlayer.instance.RunSound();
    }
}
