using System.Runtime.CompilerServices;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;


    public float AddSpeed { get; private set; }

    private float xInput;
    private float yInput;

    private string _horizontalAxisName = "Horizontal";
    private string _verticalAxisName = "Vertical";

    private float _deadZone = 0.05f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        xInput = Input.GetAxisRaw(_horizontalAxisName);
        yInput = Input.GetAxisRaw(_verticalAxisName);

        if (Mathf.Abs(yInput) > _deadZone)
            _rigidbody.AddRelativeForce(0, 0, yInput * _speed, ForceMode.Force);

        if(Mathf.Abs(xInput) > _deadZone)
            _rigidbody.AddRelativeTorque(0, xInput * _rotationSpeed, 0);
    }

}
