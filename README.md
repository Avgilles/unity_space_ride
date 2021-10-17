# Space Unity

Mon tout premier projet sur unity. J'ai pu apprendre beaucoup de concept nottament la gestion de la caméra pour le joueur, la gestion des déplacement, la création d'objet random dans une scène, le Lerp ..
 

 ![preview](/preview/preview.gif)
## Instansation des éléments

Pour créer afficher mes élément j'ai instancié et placer de manière random les différents sytème solaire. Grâce a cela chaque lancement de jeux permettera d'avoir un environement différents.


Lien vers le script : 
<a href="https://github.com/Avgilles/unity_space_ride" target="_blank" rel="nofollow">https://github.com/Avgilles/unity_space_ride/blob/master/Assets/scripts/InitiateRandomly.cs</a> 

```c#
public class InitiateRandomly : MonoBehaviour
{
    public Transform pos;
    public GameObject[] objectToInitiate;
    public int element_number = 20;
    private Vector3 posVector3;
    private int count;

    public Vector2 beetween1;
    public Vector2 beetween2;
    public Vector2 beetween3;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(count);

        for (count=0; count < element_number; count++)
        {
            InstantiateObject();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 randomVector3(Vector2 axe_x, Vector2 axe_z = default(Vector2), Vector2 axe_y = default(Vector2))
    {
        float randomPx = UnityEngine.Random.Range(axe_x.x, axe_x.y);
        float randomPy = UnityEngine.Random.Range(axe_y.x, axe_y.y);
        float randomPz = UnityEngine.Random.Range(axe_z.x, axe_z.y);

        Vector3 result = new Vector3(randomPx, randomPy, randomPz);
        return result;
    }

    private void InstantiateObject()
    {
        Vector3 Rpos = randomVector3(beetween1, beetween3);
        Vector3 scale = randomVector3(beetween2, beetween2, beetween2);

        int n = Random.Range(0, objectToInitiate.Length);
        GameObject g = Instantiate(objectToInitiate[n], transform.position + Rpos, objectToInitiate[n].transform.rotation);
        g.transform.parent = gameObject.transform;
        g.transform.localScale = scale;
    }
}
```
