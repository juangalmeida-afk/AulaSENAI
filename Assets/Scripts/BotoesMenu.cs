using UnityEngine;
using UnityEngine.SceneManagement;

public class BotoesMenu : MonoBehaviour
{
   public string nomeDoFilho = "Configurações";

 void Start()
    {
      FecharConfig();
    }
   
   public void MostrarConfig()
   {
      Transform filho = transform.Find(nomeDoFilho);
      filho.gameObject.SetActive(true);
   }

   public void FecharConfig()
   {
      Transform filho = transform.Find(nomeDoFilho);
      filho.gameObject.SetActive(false);
   }

   public void IniciarJogo()
   {
	SceneManager.LoadScene("GameScene");
   }

   public void SairParaMenu()
   {
	SceneManager.LoadScene("Menu");
   }

    
}
