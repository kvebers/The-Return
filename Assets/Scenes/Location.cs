using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    // Start is called before the first frame update
    public string locationName;

    [TextArea]
    public string description;

    public Connection[] connections;
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
}
