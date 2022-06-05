
using UnityEngine;

public class CharCamera : MonoBehaviour
{
    private Camera _camera;
    private Transform _focus;
    private int _zoom = 5;
    private float _inclination = 0.35f;
    private float _distance = 20;
    private float _speed = 5;
    private int _maxZoom = 10;
    private int _minZoom = 1;

    public void SetFocus(Transform newFocus)
    {
        _focus = newFocus;
    }

    public void ZoomUp()
    {
        if (_zoom <= _minZoom)
            return;
        _zoom = _zoom - 1;
        _camera.orthographicSize = _zoom * 0.5f;
    }
    
    public void ZoomDown()
    {
        if (_zoom >= _maxZoom)
            return;
        _zoom = _zoom + 1;
        _camera.orthographicSize = _zoom * 0.5f;
    }
    
    void Awake()
    {
        _camera = GetComponent<Camera>();
        _camera.orthographicSize = _zoom;
        _focus = transform;
    }
    void Start()
    {
        _camera.orthographic = true;
        var tempTransform = transform;
        tempTransform.Rotate(new Vector3(0, 1, 0), 45);
        tempTransform.Rotate(new Vector3(1, 0, 0), _inclination*180);
        tempTransform.position = _focus.position + new Vector3(_distance * -_inclination, _distance, _distance*-_inclination);
    }

    void Update()
    {
        var tempTransform = transform;
        float step = _speed * Time.deltaTime;
        tempTransform.position = Vector3.MoveTowards(tempTransform.position, _focus.position + new Vector3(_distance * -_inclination, _distance, _distance*-_inclination), step);
        
    }


}