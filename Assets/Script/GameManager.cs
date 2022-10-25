using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Text ammo,enemystatemachine;
    void Update()
    {
        ammo.text = PlayerController.ammo + " AMMO" ;
        if (PlayerController.ammo == 0)
        {
            enemystatemachine.text ="Finish himm";
        }
        else if (Enemycontrol.idle)
        {
            enemystatemachine.text ="İdle";
        }
        else
        {
            enemystatemachine.text ="Escape";
        }
    }
}
