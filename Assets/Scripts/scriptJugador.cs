using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptJugador : MonoBehaviour
{
    public int health, mana, type;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(vertical, 0, -horizontal);

        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
}
