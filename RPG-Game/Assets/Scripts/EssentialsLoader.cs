using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssentialsLoader : MonoBehaviour
{
    public GameObject UIScreen;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        if(UIFade.instance == null)
        {
            UIFade.instance = Instantiate(UIScreen).GetComponent<UIFade>();
        }

        if(PlayerController.instance == null)
        {
            PlayerController clone = Instantiate(player).GetComponent<PlayerController>();
            clone.transform.position = new Vector3(0, 0, 0);
            PlayerController.instance = clone;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
