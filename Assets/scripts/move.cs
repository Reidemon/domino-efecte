using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] Rigidbody rb;

    private void Update()
    {
        float h = Input.GetAxis("Horizontal") * Time.deltaTime;
    }

}
