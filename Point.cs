using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public GameObject bolt;

    private void Start()
    {
        Instantiate(bolt, transform.position, Quaternion.identity);
    }
}
