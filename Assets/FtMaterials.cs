using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FtMaterials : MonoBehaviour
{
    [System.Serializable]
    public class FootstepCollectionEntry
    {
        public string MaterialName;
        public List<MaterialEntry> MaterialCollection;
        public AK.Wwise.Switch FootstepSound;
    }
    [System.Serializable]
    public class MaterialEntry
    {
        public Material Material;
    }

    //Mettre la liste d'entrée de footsteps en public pour qu'on la voit dans Unity
    public List<FootstepCollectionEntry> collections;
    public AK.Wwise.Switch DefaultSwitch;


    private Material _currentMaterial;


    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        // Check du terrain a chaque frame
        Checkterrain();
    }


    public void Checkterrain()
    {
        // initialisation du raycast pour detecter le terrain
        RaycastHit hit;
        Ray ray = new Ray(transform.position + Vector3.up * 1 * 0.5f, -Vector3.up);
        if (Physics.Raycast(ray, out hit, 1, Physics.AllLayers, QueryTriggerInteraction.Ignore))
        {
            Renderer groundRenderer = hit.collider.GetComponentInChildren<Renderer>();
            _currentMaterial = groundRenderer ? groundRenderer.sharedMaterial : null;
            // _currentMaterial renvoi le materiaux sur lequel le joueur se trouve
           

            // initialisation d'une boucle dans la liste footstepcollection
            //on va tester chaque entree dans la collection 
            foreach (FootstepCollectionEntry fc in collections)
            {
                //on vient tester chaque materiaux dans la liste de materiaux appele dans la collection de footstep
                foreach (MaterialEntry m in fc.MaterialCollection)
                {
                    // si le materiaux actuel est le meme qu'un materiaux faisant parti de la liste de materiaux
                    if (_currentMaterial == m.Material)
                    {
                        //alors on switch sur la valeur de switch attribuée dans la footstep collection
                        fc.FootstepSound.SetValue(this.gameObject);
                    }
                    if (_currentMaterial == null) DefaultSwitch.SetValue(this.gameObject);


                }

            }

        }
    }
}
