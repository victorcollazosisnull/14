using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    public float speedX;
    private Transform _transform;
    // Start is called before the first frame update
    void Awake()
    {
        _transform = GetComponent<Transform>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _transform = new Vector2(speedX, 0);
    }
}
