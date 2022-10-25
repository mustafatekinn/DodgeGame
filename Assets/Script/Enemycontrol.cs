using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemycontrol : MonoBehaviour
{
    public Vector2 bulletdirection;
    Rigidbody2D rb2d;
    public static bool idle = true;
    public GameObject Bow;
    void Start()
    {
        Vector2 finishposition = Bow.transform.position; // Trajectory system
        rb2d = GetComponent<Rigidbody2D>(); //Object rigidbody2D
        idle = true; //state machine Controller
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.GetComponent<BulletController>() != null) // Object dangerous control?
        {
            bulletdirection =  col.gameObject.transform.position; // Which direction is the danger coming from?
            rb2d.velocity =  -bulletdirection * 2f ; // run away from danger :)
            idle = false; // idle animation of escape animation start
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Arrow") 
        {
            idle = true;  // danger has passed escape animation of run idle animation
        }
        
    }
    void Update()
    {
        if (PlayerController.ammo == 0)
        {
            StartCoroutine(Attack()); // ammo = 0 attack animation start
        }
    }
    IEnumerator Attack()
    {
        yield return new WaitForSeconds(2); // wait 2 sec for attack 
        Vector2 finishposition = Bow.transform.position; // attack position is bow position
        Vector2 position = transform.position;  // attack start position is bow position
        rb2d.velocity =  (finishposition - position) * 1f; // finish animatio;
        gameObject.transform.localScale += new Vector3(2f * Time.deltaTime,2f * Time.deltaTime,0);    
    }

}
