﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodHoleSounds : MonoBehaviour
{
    [SerializeField]
    private ScoreSystem _scoreSystem;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.GetComponent<FoodItem>() != null)
        {
            if(GetComponent<PlayAudioSoundsList>() != null)
            {
                GetComponent<PlayAudioSoundsList>().PlaySound();
                Debug.Log("FoodHoleSounds made a sound!");
            }

            if(_scoreSystem != null)
            {
                _scoreSystem.AddScore(1);
            }
            else 
            {
                Debug.Log("Score System was not assigned to Food Hole. Score is not tracked");
            }
        }   
    }
}
