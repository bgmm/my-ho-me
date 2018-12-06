using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlePlay : MonoBehaviour {

  
        [SerializeField]
        private ParticleSystem ps;

        void Start()
        {
            // This one is not even needed
            ps.Stop();
        }

        public void PlayParticles()
        {
            ps.Stop();
            ps.Play();
        }
    }