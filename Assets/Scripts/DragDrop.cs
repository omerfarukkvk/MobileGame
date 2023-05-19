using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    public bool isDrag = false;
    public GameObject player;
    public Vector3 playerPos;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position),Vector2.zero);

                if (hit.collider != null && hit.collider.tag == "Player")
                {
                    isDrag = true;
                    player = hit.collider.gameObject;
                    playerPos = player.transform.position;
                }
            }
            if (touch.phase == TouchPhase.Moved)
            {
                if (isDrag)
                {
                    playerPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                    playerPos.z = 0;
                }
            }
            if (touch.phase == TouchPhase.Ended)
            {
                isDrag = false;
            }
        }

        if (isDrag)
        {
            player.transform.position = playerPos;
        }
    }
}
