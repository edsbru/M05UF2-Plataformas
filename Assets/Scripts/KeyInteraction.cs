using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInteraction : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = CollectedBlueKey;
        door.AbrirPuerta();
        Destroy(this);
    }
    public Sprite CollectedBlueKey;
    public DoorDisappear door;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
