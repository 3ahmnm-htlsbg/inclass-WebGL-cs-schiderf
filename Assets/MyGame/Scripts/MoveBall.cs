using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    //public GameObject PosBallTopLeft;
    //public GameObject PosBallBottomLeft;
    //public GameObject PosBallTopRight;
    //public GameObject PosBallBottomRight;

    [SerializeField] private GameObject[] ballPositions;
    [SerializeField] private GameObject Sphere;

    public void MoveSphere()
    {
        Debug.Log(Random.Range(0, 2));
    }

}
