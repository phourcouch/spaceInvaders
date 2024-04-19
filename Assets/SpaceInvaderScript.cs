using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceInvaderScript : MonoBehaviour
{
    
    public float spaceInvaderSpeed = 9.0f;
    private float xtrans = -1;
    private float ytrans = 1;
    private static int killCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        float yval = Random.Range(GeneralScript.bottom, GeneralScript.top);
        float xval = Random.Range(GeneralScript.left, GeneralScript.right);
        transform.position = new Vector3(xval, yval / 2, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y <= GeneralScript.bottom)
        {
            GameObject.Find("Main Camera").GetComponent<GeneralScript>().GameOver();

        }
        if (killCount == GeneralScript.numInvaders)
        {
            GameObject.Find("Main Camera").GetComponent<GeneralScript>().YouWin();

        }

        if (transform.position.x <= GeneralScript.left) {
            xtrans = 1;
        }
        if (transform.position.x >= GeneralScript.right)
        {
            xtrans = -1;
        }



        transform.Translate(xtrans * Time.deltaTime, -ytrans*Time.deltaTime, 0);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("CannonBall"))
        {
            killCount++;
            Destroy(gameObject);
            print(killCount);
        }

    }
}
