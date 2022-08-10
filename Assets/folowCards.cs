using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class folowCards : MonoBehaviour
{
    [SerializeField] GameObject card; 
    // Start is called before the first frame update
    void Start()
    {
        transform.position = card.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = card.transform.position;
    }
}
