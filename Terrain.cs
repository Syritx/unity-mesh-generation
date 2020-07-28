using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrain : MonoBehaviour
{

    [SerializeField] GameObject terrainTemplate;
    int length = 10;

    Vector3[] verticesTemp = new Vector3[4] {
        new Vector3(0,0,0),
        new Vector3(1,0,0),
        new Vector3(0,0,1),
        new Vector3(1,0,1)
    };

    void Start() {
        for (int x = 0; x < length; x++) {
            for (int z = 0; z < length; z++) {

                GameObject terrain = Instantiate(terrainTemplate,new Vector3(x,0,z),Quaternion.identity);
                terrain.GetComponent<Tile>().vertices = verticesTemp;
                terrain.GetComponent<Tile>().RenderMesh();
            }
        }
    }
}
