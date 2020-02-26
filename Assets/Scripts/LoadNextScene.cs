using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using RPG.Control;

namespace RPG.Combat
{
    public class LoadNextScene : MonoBehaviour
    {
        AIController aiController;
        private void Start()
        {
            aiController = GetComponent<AIController>();
        }
        private void Update()
        {
            if (aiController.InAttackRangeOfPlayer())
            {
                Destroy(gameObject, 1.0f);
                SceneManager.LoadScene(5);
            }
        }
    }
}
