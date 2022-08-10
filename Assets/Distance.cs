using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public GameObject it1_up_right;
    public GameObject it1_bottom_right;
    public GameObject it1_bottom_left;

    public GameObject it2_up_left;
    public GameObject it2_up_right;
    public GameObject it2_bottom_right;
    public GameObject it2_bottom_left;

    public GameObject it3_up_left;
    public GameObject it3_bottom_right;
    public GameObject it3_bottom_left;

    public GameObject it4_up_left;
    public GameObject it4_up_right;
    public GameObject it4_bottom_right;

    public GameObject it5_up_left;
    public GameObject it5_up_right;
    public GameObject it5_bottom_right;
    public GameObject it5_bottom_left;

    public GameObject it6_up_left;
    public GameObject it6_up_right;
    public GameObject it6_bottom_left;
	
    
    float distance_it1_it2_0;
    float distance_it1_it2_1; 
    float distance_it1_it4_0;
    float distance_it1_it4_1; 
    float distance_it2_it3_0;
    float distance_it2_it3_1; 
    float distance_it2_it5_0;
    float distance_it2_it5_1; 
    float distance_it3_it6_0;
    float distance_it3_it6_1; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        // 1 2
        distance_it1_it2_0 = Vector3.Distance (it1_up_right.transform.position, it2_up_left.transform.position);
        distance_it1_it2_1 = Vector3.Distance (it1_bottom_right.transform.position, it2_bottom_left.transform.position);
        if(distance_it1_it2_0 <0.02 && distance_it1_it2_1<0.02){
            Debug.Log("Distance 1-2 : " + distance_it1_it2_0 + ", " + distance_it1_it2_1);
            Debug.Log("1 and 2 are joined.");
        }

        // 1 4
        distance_it1_it4_0 = Vector3.Distance (it1_bottom_left.transform.position, it4_up_left.transform.position);
        distance_it1_it4_1 = Vector3.Distance (it1_bottom_right.transform.position, it4_up_right.transform.position);
        if(distance_it1_it4_0<0.02 && distance_it1_it4_1<0.02){
            Debug.Log("Distance 1-4 : " + distance_it1_it4_0 + ", " + distance_it1_it4_1);
            Debug.Log("1 and 4 are joined.");
        }

        // 2 3
        distance_it2_it3_0 = Vector3.Distance (it2_up_right.transform.position, it3_up_left.transform.position);
        distance_it2_it3_1 = Vector3.Distance (it2_bottom_right.transform.position, it3_bottom_left.transform.position);
        if(distance_it2_it3_0<0.02 && distance_it2_it3_1<0.02){
            Debug.Log("Distance 2-3 : " + distance_it2_it3_0 + ", " + distance_it2_it3_1);
            Debug.Log("2 and 3 are joined.");
        }

        // 2 5
        distance_it2_it5_0 = Vector3.Distance (it2_bottom_left.transform.position, it5_up_left.transform.position);
        distance_it2_it5_1 = Vector3.Distance (it2_bottom_right.transform.position, it5_up_right.transform.position);
        if(distance_it2_it5_0<0.02 && distance_it2_it5_1<0.02){
            Debug.Log("Distance 2-5 : " + distance_it2_it5_0 + ", " + distance_it2_it5_1);
            Debug.Log("2 and 5 are joined.");
        }

        // 3 6
        distance_it3_it6_0 = Vector3.Distance (it3_bottom_left.transform.position, it6_up_left.transform.position);
        distance_it3_it6_1 = Vector3.Distance (it3_bottom_right.transform.position, it6_up_right.transform.position);
        if(distance_it3_it6_0<0.02 && distance_it3_it6_1<0.02){
            Debug.Log("Distance 3-6 : " + distance_it3_it6_0 + ", " + distance_it3_it6_1);
            Debug.Log("3 and 6 are joined.");
        }

    }

}
