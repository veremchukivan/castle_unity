using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sun : MonoBehaviour
{
    public float rotat1;

    public Transform Player11;
    // Start is called before the first frame update
    void Start()
    {
        rotat1 = 0.04f;
        
    }

    // Update is called once per frame
    void Update()
    {
        Player11.Rotate(rotat1 * new Vector3(0, 1, 0));
    }
}
