using UnityEngine;

public class LastQuestion : MonoBehaviour
{
    public FinalGame final;
    public RandomSelect random;
    public ActiveQuestion active;
  public void LastQ()
    {
            print("Esta debería ser la ultima Pregunta");
            final.FinalScreen();

    }
}
