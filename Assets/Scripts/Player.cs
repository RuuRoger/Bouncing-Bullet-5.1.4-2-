using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Public Properties
    public float speedPlayer;

    //Private attributes
    private Animator _animatorPlayer;
    private SpriteRenderer _spriteRendererPlayer;

    //Methods

    private void Start()
    {
        _animatorPlayer = GetComponent<Animator>();
        _spriteRendererPlayer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        //Player move
        transform.Translate(Vector2.right * Input.GetAxis("Horizontal") * Time.deltaTime * speedPlayer);
        transform.Translate(Vector2.up * Input.GetAxis("Vertical") * Time.deltaTime * speedPlayer);

        //Player animation walking
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) _animatorPlayer.SetBool("Walk", true);
        else _animatorPlayer.SetBool("Walk",false);

        //Active Flip
        if (Input.GetAxis("Horizontal") < 0) _spriteRendererPlayer.flipX = true;
        if (Input.GetAxis("Horizontal") > 0) _spriteRendererPlayer.flipX = false;


    }
}