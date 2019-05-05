﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class character : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Animator animator;

    protected Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime); //Time.deltaTime ensures players moves at constant speed, no matter the FPS.

        //AnimateMovement();
    }

    //public void AnimateMovement()
    //{
    //    animator.SetFloat("x", direction.x);
    //    animator.SetFloat("y", direction.y);
    //}
}
