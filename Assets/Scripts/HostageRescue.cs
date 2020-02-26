using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RPG.Control;

public class HostageRescue : MonoBehaviour
{
    [SerializeField] private Text RescueText;
    AIController aiController;
    void Start()
    {
        aiController = GetComponent<AIController>();
    }
    // Update is called once per frame
    void Update()
    {
        if (aiController.InAttackRangeOfPlayer())
        {
            StartCoroutine(ShowMessage(2.0f));
        }
    }
    IEnumerator ShowMessage(float delay)
    {
        print("saved");
        RescueText.text = "Thankyou! You saved my life.";
        yield return new WaitForSeconds(delay);
        RescueText.text = "";
    }
}
