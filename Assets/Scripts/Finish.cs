using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
   private AudioSource FinishSoundEffect;
   private bool LevelCompleted;
    void Start()
    {
        FinishSoundEffect = GetComponent<AudioSource>();
    }

   private void OnTriggerEnter2D(Collider2D collision) {
          if (collision.gameObject.name == "Player" && !LevelCompleted)
        {
            FinishSoundEffect.Play();
            LevelCompleted = true;
            Invoke("CompleteLevel", 2f);

        }
   }

   private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
