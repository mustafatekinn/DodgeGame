using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HavanLookat : MonoBehaviour
{

    void Update()
    {
        Vector3 mouseposi = Input.mousePosition;
        mouseposi = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 directions = new Vector2(mouseposi.x-transform.position.x,mouseposi.y-transform.position.y);
        transform.up = directions;
    }
}
