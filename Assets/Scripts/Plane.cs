using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fligth : MonoBehaviour
{
     public float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                transform.position -= new Vector3(speed, 0, 0);
            }else if(Input.GetKey(KeyCode.DownArrow)){
                transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
                transform.position += new Vector3(speed, 0, 0);
            }
             if (Input.GetKey(KeyCode.RightArrow))
            {
              transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
              transform.position += new Vector3(0, 0, speed);
            }else if(Input.GetKey(KeyCode.LeftArrow)){
               transform.rotation = Quaternion.Euler(new Vector3(0, -90, 0));
               transform.position -= new Vector3(0, 0, speed);
            }
 
    }
}
