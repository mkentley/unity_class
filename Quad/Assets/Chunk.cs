using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public Material atlas;
    public int width = 2;
    public int height = 2;
    public int depth = 2;
    public  Block[,,]  blocks;

    // Start is called before the first frame update
    void Start()
    {

        MeshFilter mf = this.gameObject.AddComponent<MeshFilter>();
        MeshRenderer mr = this.gameObject.AddComponent<MeshRenderer>();
        mr.material = atlas;
        blocks = new Block[width, depth, height];
        for(int z=0;z<depth;z++)
        {
            for(int y=0;y<height;y++)
            {
                for (int x = 0; x < width; x++)
                {
                    blocks[x, y, z] = new Block(new Vector3(x, y, z), MeshUtils.BlockType.DIRT);

                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
