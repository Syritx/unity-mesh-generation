using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Vector3[] vertices = new Vector3[4];

    public void RenderMesh() {
        MeshRenderer renderer = gameObject.AddComponent<MeshRenderer>();
        MeshFilter filter = gameObject.AddComponent<MeshFilter>();

        renderer.sharedMaterial = new Material(Shader.Find("Standard"));

        Mesh mesh = new Mesh();
        mesh.vertices = vertices;

        int[] triangles = new int[6] {
            0,2,1,
            2,3,1
        }; mesh.triangles = triangles;

        mesh.normals = new Vector3[4] {
            -Vector3.forward,
            -Vector3.forward,
            -Vector3.forward,
            -Vector3.forward,
        };

        mesh.uv = new Vector2[4] {
            new Vector2(0, 0),
            new Vector2(1, 0),
            new Vector2(0, 1),
            new Vector2(1, 1)
        };

        filter.mesh = mesh;
    }
}
