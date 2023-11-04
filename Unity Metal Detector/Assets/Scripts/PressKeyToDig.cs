using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressKeyToDig : MonoBehaviour
{
    public GameObject instruction;
    private bool isPlayerWithinDiggingRange;

    //[Header("Events")]
    //public GameEvent onPlayerWithinDiggingRange;

    // Start is called before the first frame update
    void Start()
    {
        instruction.SetActive(false);
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
        instruction?.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isPlayerWithinDiggingRange)
        {
            instruction?.SetActive(false);
            isPlayerWithinDiggingRange = false;
            //onPlayerWithinDiggingRange.Raise(this, isPlayerWithinDiggingRange);
        }
    }
}
