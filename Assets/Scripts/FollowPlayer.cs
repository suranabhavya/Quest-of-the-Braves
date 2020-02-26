using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RPG.Control;

namespace RPG.Combat
{
    public class FollowPlayer : MonoBehaviour
    {
        public AudioClip HostageCollected;
        public AudioSource HostageCollectedSource;
        public int count = 0;
        AIController aiController;
        private void Start()
        {
            aiController = GetComponent<AIController>();
        }
        private void Update()
        {
            if (aiController.InAttackRangeOfPlayer())
            {
                count++;
                HostageCollectedSource.Play();
                Destroy(gameObject, 1.0f);
            }
        }
    }
}
    
