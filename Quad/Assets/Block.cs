using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block
{
    public Mesh mesh;

    // Start is called before the first frame update
    public Block(Vector3 offset, MeshUtils.BlockType type)
    {
        Quad[] quads = new Quad[6];
        quads[0] = new Quad(MeshUtils.BlockSide.BOTTOM, offset,type);
        quads[1] = new Quad(MeshUtils.BlockSide.TOP, offset, type );
        quads[2] = new Quad(MeshUtils.BlockSide.LEFT, offset, type );
        quads[3] = new Quad(MeshUtils.BlockSide.RIGHT, offset, type );
        quads[4] = new Quad(MeshUtils.BlockSide.FRONT, offset, type);
        quads[5] = new Quad(MeshUtils.BlockSide.BACK, offset, type);

        Mesh[] sideMeshes = new Mesh[6];
        sideMeshes[0] = quads[0].mesh;
        sideMeshes[1] = quads[1].mesh;
        sideMeshes[2] = quads[2].mesh;
        sideMeshes[3] = quads[3].mesh;
        sideMeshes[4] = quads[4].mesh;
        sideMeshes[5] = quads[5].mesh;

       mesh = MeshUtils.MergeMeshes(sideMeshes);
    }


    }
