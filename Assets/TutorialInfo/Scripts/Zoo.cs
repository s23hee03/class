using UnityEngine;

public class Zoo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Animal tom = new Animal();
        tom.name = "Tom";
        tom.sound = "야옹~";

        Animal jerry = new Animal();
        jerry.name = "Jerry";
        jerry.sound = "찍";

        jerry = tom;
        jerry.name = "미키";
  

        tom.Playsound();
        jerry.Playsound();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
