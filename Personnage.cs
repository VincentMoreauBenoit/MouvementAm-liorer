using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Personnage : MonoBehaviour
{

    protected int life = 0;
    protected float speed;
    protected float deplacement = 0;
    private float tempsEcouler = 0;
    private float tempsFinaux = 0;
    protected float gravity;
    private bool avancer = true;
    CharacterController Cac;
    Vector3 moveD = Vector3.zero;


    public Personnage(int life, int speed, int deplacement)
    {
        this.life = life;
        this.speed = speed;
        this.deplacement = 5;
        gravity = 20f;

    }
    public void Start()
    {
        Cac = GetComponent<CharacterController>();
    }

    public void bouger(float speed, float deplacement)
    {

        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                
                temps();
                avancer = false;
                Debug.Log(tempsFinaux);
                Debug.Log(tempsEcouler);
                while (tempsEcouler <= tempsFinaux)
                {
                    moveD = new Vector3(0, 0, Time.deltaTime * 200);
                    deltaTemps();
                    Debug.Log(tempsEcouler);
                }

            }




            // moveD = new Vector3(0, 0, Input.GetAxis("Vertical"));
            // moveD = transform.TransformDirection(moveD);
            //moveD *= speed;



            moveD.y -= gravity * Time.deltaTime;


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Rotate(0, 90, 0);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Rotate(0, -90, 0);
            }

            Cac.Move(moveD * Time.deltaTime);

        }
        void temps()
        {
            tempsFinaux = tempsEcouler + 3;

        }
        void deltaTemps()
        {

            tempsEcouler += Time.deltaTime;

        }
    }
}
