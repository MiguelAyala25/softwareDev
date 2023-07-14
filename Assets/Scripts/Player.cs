using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 5f;
    private Vector2 targetposition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            setTargetPosition();
        }
        moveFunction();
    }

    void setTargetPosition()
    {
        targetposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void moveFunction()
    {
        Vector2 direction = new Vector2(targetposition.x - transform.position.x, targetposition.y - transform.position.y);

        transform.position = Vector2.MoveTowards(transform.position, targetposition, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }

}
