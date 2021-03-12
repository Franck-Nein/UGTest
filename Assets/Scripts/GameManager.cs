using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Renderer bg;
    public Renderer cloud1;
    public Renderer cloud2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            //Mover BG
            bg.material.mainTextureOffset = bg.material.mainTextureOffset + new Vector2(0.015f, 0) * Time.deltaTime;
            cloud1.material.mainTextureOffset = cloud1.material.mainTextureOffset + new Vector2(0.029f, 0) * Time.deltaTime;
            cloud2.material.mainTextureOffset = cloud2.material.mainTextureOffset + new Vector2(0.049f, 0) * Time.deltaTime;
        
    }
}
