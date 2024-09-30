using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _rotationSpeed;

    private ImprovementsAbilities _ability;

    private float _xInput;
    private float _yInput;
    private float _deadZone = 0.05f;

    private string _horizontalAxisName = "Horizontal";
    private string _verticalAxisName = "Vertical";

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _ability = GetComponent<ImprovementsAbilities>();
    }
    private void Update()
    {
        _xInput = Input.GetAxisRaw(_horizontalAxisName);
        _yInput = Input.GetAxisRaw(_verticalAxisName);
    }

    private void FixedUpdate()
    {
        if (Mathf.Abs(_yInput) > _deadZone)
            _rigidbody.AddRelativeForce(0, 0, _yInput * _ability.Speed, ForceMode.Force);

        if (Mathf.Abs(_xInput) > _deadZone)
            _rigidbody.AddRelativeTorque(0, _xInput * _rotationSpeed, 0);
    }

}
