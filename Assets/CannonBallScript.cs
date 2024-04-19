using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallScript : MonoBehaviour
{
    private float totalTime;
    public float cannonBallSpeed = 9.0f;


    // Start is called before the first frame update
    void Start()
    {
        totalTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float ytrans = Time.deltaTime * cannonBallSpeed;
        transform.Translate(0, ytrans, 0);

        totalTime += Time.deltaTime;
     //   if(totalTime >= 10.0f )
    //    {
      //      Destroy(gameObject);
      //  }
      if(transform.position.y > GeneralScript.top)
        {
            Destroy(gameObject);
        }
    }
}
