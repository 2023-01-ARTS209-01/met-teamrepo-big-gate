using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction : MonoBehaviour{
    // Controles the horizontal speed of person
    [SerializeField] float horizontalSpeed = 0;
    // Controles the vertical speed of person
    [SerializeField] float verticalSpeed = 0;
    // Controles the walk speed of person
    [SerializeField] float walkSpeed = 3;

    // Start is called before the first frame update
    void Start() {}
    // Update is called once per frame
    void Update() {
        horizontalSpeed = Input.GetAxis("Horizontal") * walkSpeed * Time.deltaTime;
        verticalSpeed = Input.GetAxis("Vertical") * walkSpeed * Time.deltaTime;
        transform.Translate(horizontalSpeed, verticalSpeed, 0);
    }
}