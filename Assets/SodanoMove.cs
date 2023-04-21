using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SodanoMove : MonoBehaviour
{
    [SerializeField] float vertSpeed = 0.005f;
    [SerializeField] float horizSpeed = 0.005f;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertAmount = Input.GetAxis("Vertical") * vertSpeed * Time.deltaTime;
        float horizAmount = Input.GetAxis("Horizontal") * horizSpeed * Time.deltaTime;

        transform.Translate (0, vertAmount, 0);
        transform.Translate (horizAmount , 0, 0);
    }
}
