using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [System.Serializable]
    public enum BlockSide { BOTTOM, TOP, LEFT, RIGHT, FRONT, BACK };
    public Material atlas;

    // Start is called before the first frame update
    void Start()
    {
        MeshFilter mf = this.gameObject.AddComponent<MeshFilter>();
        MeshRenderer mr = this.gameObject.AddComponent<MeshRenderer>();
        mr.material = atlas;

        Quad[] quads = new Quad[6];
        quads[0] = new Quad(BlockSide.FRONT, Vector3.zero);
        quads[1] = new Quad(BlockSide.BACK, Vector3.zero);
        quads[2] = new Quad(BlockSide.TOP, Vector3.zero);
        quads[3] = new Quad(BlockSide.BOTTOM, Vector3.zero);
        quads[4] = new Quad(BlockSide.LEFT, Vector3.zero);
        quads[5] = new Quad(BlockSide.RIGHT, Vector3.zero);

        Mesh[] sideMeshes = new Mesh[6];
        sideMeshes[0] = quads[0].mesh;
        sideMeshes[1] = quads[1].mesh;
        sideMeshes[2] = quads[2].mesh;
        sideMeshes[3] = quads[3].mesh;
        sideMeshes[4] = quads[4].mesh;
        sideMeshes[5] = quads[5].mesh;

        mf.mesh = MeshUtils.MergeMeshes(sideMeshes);
        mf.mesh.name = "Cube_0_0_0";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
