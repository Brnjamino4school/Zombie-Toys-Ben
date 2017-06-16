//This script controls the health functions of the enemies. This script also is responsible for turning
//the enemy movement and attack off in the event of the enemy being defeated. Since the enemies aren't destroyed after
//being defeated (they are just disabled since the game maintains 'pools' or collections of enemies) there is
//code in place to reset the values of the enemies when they respawn

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager: MonoBehaviour
{
    public bool Bertha = true;
    public EnemyHealth boss;
   

     
    void Update()
    {
        if (Bertha == false)
        {
            Invoke("nextLevel", 5);
            Bertha = true;
        }
        if (boss.currentHealth <= 0)
        {
            Bertha = false;
        }

    } 
    void nextLevel()
    {
       
        SceneManager.LoadScene("Level2");
    }
}
