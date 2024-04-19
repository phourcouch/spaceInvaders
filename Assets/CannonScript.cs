using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour
{
    public Transform cannonBallPrefab;
    public float cannonSpeed =9.0f;
    // Start is called before the first frame update
    void Start()
    {
      
        transform.position = new Vector3(0, GeneralScript.bottom, 0);
    }


    // Update is called once per frame
    void Update()
    {
       
        float xtrans = Input.GetAxis("Horizontal") * Time.deltaTime * cannonSpeed;

        transform.Translate(xtrans, 0, 0);

        if (transform.position.x < GeneralScript.left ) {
            transform.position = new Vector3(GeneralScript.left, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > GeneralScript.right)
        {
            transform.position = new Vector3(GeneralScript.right, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown("space"))
        {
            Instantiate(cannonBallPrefab, transform.position, transform.rotation);
        }

       

    }
}
