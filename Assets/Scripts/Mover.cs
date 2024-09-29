using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _rotationSpeed;

    private ImprovementsAbilities _ability;

    private float xInput;
    private float yInput;

    private string _horizontalAxisName = "Horizontal";
    private string _verticalAxisName = "Vertical";

    private float _deadZone = 0.05f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _ability = GetComponent<ImprovementsAbilities>();
    }

    private void Update()
    {
        xInput = Input.GetAxisRaw(_horizontalAxisName);
        yInput = Input.GetAxisRaw(_verticalAxisName);

        if (Mathf.Abs(yInput) > _deadZone)
            _rigidbody.AddRelativeForce(0, 0, yInput * _ability.Speed, ForceMode.Force);

        if(Mathf.Abs(xInput) > _deadZone)
            _rigidbody.AddRelativeTorque(0, xInput * _rotationSpeed, 0);
    }

}
