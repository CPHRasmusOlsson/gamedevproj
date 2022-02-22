using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemyMovement : MonoBehaviour
{
    public Transform Player;

    private float aggroRange = 5f;

    public Rigidbody2D rigidBody;
    private Vector2 movement;
    private float speed = 5f;
    private float rotSpeed = 30f;
    private Vector3 vec = Vector3.forward;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void OrbitTarget(){
        if(Time.deltaTime % 3 == 0){
            if(Time.deltaTime % 2 == 0) {
                vec = Vector3.back;
            } else {
                vec = Vector3.forward;
            }
        }
        //transform.RotateAround(target.transform.position, Vector3.up, 20 * Time.deltaTime);
        transform.RotateAround(Player.transform.position, vec, rotSpeed * Time.deltaTime);
    }

    void FixedUpdate()
    {
        if(Vector3.Distance(transform.position, Player.transform.position) > aggroRange)
        {
            transform.position = Vector2.MoveTowards(
                transform.position, 
                Player.transform.position, 
                speed * Time.deltaTime);
        } else 
        {
            OrbitTarget();
        }
    }
}
