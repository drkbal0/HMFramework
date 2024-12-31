using UnityEngine;

namespace HelloMarioFramework
{
    public class PesoEnemigo : MonoBehaviour
    {
        [Range(1, 10)]
        public float peso = 1f;

        public int vida = 5; // Añade esta línea
    }
}