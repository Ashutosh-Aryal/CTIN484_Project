﻿using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartGame()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().path);
        EnemyBehavior.s_GameOverMenu.SetActive(false);
        EnemyBehavior.s_HasPlayerLost = false;
    }

}
