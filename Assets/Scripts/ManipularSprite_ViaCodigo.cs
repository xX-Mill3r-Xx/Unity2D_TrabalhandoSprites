using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class ManipularSprite_ViaCodigo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //codigo para movimentar uma sprite nos eixos x,y,z
        //transform.Translate(new Vector3(0.3f,-0.3f,0));

        //codigo para movimentar uma sprite com o rotate;
        //transform.Rotate(new Vector3(0,0,0.3f));

        //Codigo para escalonar uma sprite;
        transform.localScale += new Vector3(0.3f,0.3f,0);
    }
}
