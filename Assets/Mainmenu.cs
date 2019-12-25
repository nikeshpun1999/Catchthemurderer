using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
   public void PlayGame()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

   }
   public void firstintro()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
   }

    public void nextscene()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
   }
   public void ashimscene()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
   }
   public void nikhilscene()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
   }
   public void prakashscene()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+3);
   }
   public void nikeshscene()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+4);
   }
   public void ashishscene()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+5);
   }
   public void sagarscene()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+6);
   }

   public void backfromashim()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
   }
   public void backfromnikhil()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
   }
   public void backfromprakash()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-3);
   }
   public void backfromnikesh()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-4);
   }
   public void backfromashish()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-5);
   }
   public void backfromsagar()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-6);
   }
 
    public void backbtn()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
   }
    
     public void ashimlocation()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+6);
   }
   public void ashimoccupation()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+7);
   }
   public void ashimobserve()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+8);
   }
   public void ashimtrigger()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+9);
   }
   public void ashimothermemo()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+10);
   }
   public void guess()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+11);
   }

   public void backtotalk()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-12);
   }
   



   public void QuitGame()
   {
       Debug.Log("QUIT");
       Application.Quit();
   }
}
