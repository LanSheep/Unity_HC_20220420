using UnityEngine;

/// <summary>
/// �ǲ� �D�R�A API
/// API ���W�S�� static
/// </summary>
public class LearnAPInoStatic : MonoBehaviour
{
    public Transform traA;
    public Light lightA;
    public Transform traB;
    private void Start()
    {
        /// �D�R�A�ݩ� properties
        /// 1. ���o get
        /// ����G
        /// - �����O�������
        /// - ���骫��
        /// - ���s��ӹ��骫��
        /// ���W��.�D�R�A�ݩʦW��
        print("A ���󪺮y�СG" + traA.position);
        traA.position = new Vector3(1.57f, 0.5f, -15);
        lightA.color = new Color(1, 0, 0);

    }

    private void Update()
    {
        traB.Rotate(0, 10, 0);
    }
}
