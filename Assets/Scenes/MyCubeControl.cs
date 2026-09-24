using UnityEngine;

public class MyCubeControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // s = u * t      S - distance  = u  (velocity)  *  t (time)

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += 1f * Vector3.up * Time.deltaTime;
        }

    }
       
       
    
}
