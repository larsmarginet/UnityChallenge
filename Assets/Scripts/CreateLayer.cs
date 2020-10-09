using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLayer : MonoBehaviour
{
    public GameObject block;
    public uint Width = 3;
    public uint Height = 3;
    public uint Depth = 3;
    public uint yPos = 0;

    void Start()
    {
        for (uint x = 0; x < Width; ++x)
        {
            for (uint y = 0; y < Height; ++y)
            {
                for (uint z = 0; z < Depth; ++z)
                {
                    if (x > 0 && x < Width - 1 &&
                        y > 0 && y < Height - 1 &&
                        z > 0 && z < Depth - 1)
                        continue;

                    Instantiate(block, new Vector3(x, yPos, z), Quaternion.identity);
                }
            }
        }
    }

   
    void Update()
    {
        
    }
}
