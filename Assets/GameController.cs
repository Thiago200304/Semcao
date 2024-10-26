using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Método para carregar a cena chamada "Cena1"
    public void CarregarCena1()
    {
        SceneManager.LoadScene("Cena1");
    }

    // Método para sair do jogo
    public void SairDoJogo()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Para parar o jogo no editor
#else
            Application.Quit(); // Para fechar o jogo na build final
#endif
    }
}
