using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour

{

    [SerializeField] float moveSpeed = 0.02f;
    // Start is called before the first frame update
    void Start()

    {
        transform.Translate(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(0.1f, 0.01f, 0.1f);
        MovePlayer();
        

    }

    void MovePlayer()
    {

        float xValue = Input.GetAxis("Vertical") * -1 * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Horizontal")  * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
