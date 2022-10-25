using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Arrow;
    public float LaunchForce;
    bool reload;
    public static int ammo = 5; // player ammo

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && (ammo > 0) && (!reload)) // left click
        {
            ammo--; 
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot()
    {
        reload = true; // reload for cooldown
        GameObject ArrowIns = Instantiate(Arrow,transform.position,transform.rotation);
        ArrowIns.GetComponent<Rigidbody2D>().velocity = transform.right * LaunchForce;
        yield return new WaitForSeconds(2); //cooldown time
        reload = false; // cooldown finish
    } 
}
