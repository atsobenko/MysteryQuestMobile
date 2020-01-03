using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

namespace Lights
{
    public class Candle : MonoBehaviour
    {
        private Light2D _light;
        private float _timer;
        public float delay, minValue, maxValue;

        // Start is called before the first frame update
        private void Start()
        {
            _light = GetComponent<Light2D>();
            _timer = Time.time;
        }

        // Update is called once per frame
        private void Update()
        {
            if (!(Time.time - _timer >= delay))
            {
                return;
            }
            
            _timer = Time.time;
            _light.intensity = Random.Range(minValue, maxValue);
        }
    }
}
