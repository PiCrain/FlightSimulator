using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePilot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("plane pilot script added to: "+gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += transform.forward * Time.deltaTime * -30.0f;
        transform.Rotate( Input.GetAxis("Vertical"),0.0f, -Input.GetAxis("Horizontal") );

        float terrainHeightWhereWeAre = Terrain.activeTerrain.SampleHeight(transform.position);

        if(terrainHeightWhereWeAre > transform.position.y)
        {

            transform.position = new Vector3(transform.position.x,
                                             terrainHeightWhereWeAre,
                                             transform.position.z
                                             );

        }
    }
}
