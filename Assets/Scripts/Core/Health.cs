using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace RPG.Core
{
    public class Health : MonoBehaviour
    {
        public AudioClip MusicClip;
        public AudioSource MusicSource;
        public AudioClip DeathClip;
        public AudioSource DeathSource; 
        [SerializeField] public float healthPoints = 100f;
        [SerializeField] private Text healthText;
        bool isDead = false;
        void Start()
        {
            MusicSource.clip = MusicClip;
        }
        public bool IsDead()
        {
            return isDead;
        }
        public void TakeDamage(float damage)
        {
            healthPoints = Mathf.Max(healthPoints - damage, 0);
            MusicSource.Play();
            if (healthPoints == 0)
            {
                Die();
            }
            healthText.text = healthPoints.ToString("F");
        }
        private void Die()
        {
            
            if (isDead) return;
            isDead = true;
            GetComponent<Animator>().SetTrigger("die");
            GetComponent<ActionScheduler>().CancelCurrentAction();
            DeathSource.Play();
        }
    }
}
