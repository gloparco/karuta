using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressKeyToDig : MonoBehaviour
{
    public GameObject instruction;
    public GameObject image;
    private bool isPlayerWithinDiggingRange;

    //[Header("Events")]
    //public GameEvent onPlayerWithinDiggingRange;

    // Start is called before the first frame update
    void Start()
    {
        instruction.SetActive(false);
        image.SetActive(false);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            instruction?.SetActive(true);
            isPlayerWithinDiggingRange = true;
            //onPlayerWithinDiggingRange.Raise(this, isPlayerWithinDiggingRange);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (image.activeSelf)
        {
            gameObject.SetActive(false);
        }
        instruction?.SetActive(false);
        image?.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isPlayerWithinDiggingRange)
        {
            instruction?.SetActive(false);
            isPlayerWithinDiggingRange = false;
            image?.SetActive(true);
            //onPlayerWithinDiggingRange.Raise(this, isPlayerWithinDiggingRange);
        }
    }
}
