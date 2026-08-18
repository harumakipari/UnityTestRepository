using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float aaa;

    private float angle;


    public float Angular { get { return aaa; } }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Test");
    }
}
