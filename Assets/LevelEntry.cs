using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEntry : MonoBehaviour
{
    public static string activeTag;
    public string sourceTag;

    // Start is called before the first frame update
    void Start()
    {
        if(activeTag == sourceTag){
            Player.instance.teleport(transform.position);
            activeTag = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
