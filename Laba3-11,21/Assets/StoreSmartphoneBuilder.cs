using UnityEngine;

public class StoreSmartphoneBuilder : MonoBehaviour, ISmartphoneSale
{
    [SerializeField] private ProductData _girl;
    [SerializeField] private ProductData _girl1;
    [SerializeField] private ProductData _girl2;
    [SerializeField] private ProductData _girl3;
    [SerializeField] private ProductData _girl4;
    [SerializeField] private ProductData _beautiful;
    [SerializeField] private ProductData _smart;
    [SerializeField] private ProductData _young;
    [SerializeField] private ProductData _rich;
    [SerializeField] private ProductData _charismatic;
    [SerializeField] private ProductData _notjealous;
    [SerializeField] private ProductData _purposeful;
    [SerializeField] private ProductData _nicecoking;
    [SerializeField] private ProductData _nicespeach;
    [SerializeField] private ProductData _niceprogramming;
    [SerializeField] private ProductData _playgames;


    public Compectation Complect { get; private set; } = new Compectation();

    public void Add()
    {
        InstanceProduct(_girl);
    }

    public void Add1()
    {
        InstanceProduct(_girl1);
    }

    public void Add2()
    {
        InstanceProduct(_girl2);
    }
    public void Add3()
    {
        InstanceProduct(_girl3);
    }
    public void Add4()
    {
        InstanceProduct(_girl4);
    }

    public void AddBeautiful()
    {
        InstanceProduct(_beautiful);
    }

    public void AddSmart()
    {
        InstanceProduct(_smart);
    }
    public void AddYoung()
    {
        InstanceProduct(_young);
    }

    public void AddRich()
    {
        InstanceProduct(_rich);
    }

    public void AddCharismatic()
    {
        InstanceProduct(_charismatic);
    }
    public void AddNotJealous()
    {
        InstanceProduct(_notjealous);
    }

    public void AddPurposeful()
    {
        InstanceProduct(_purposeful);
    }

    public void AddNiceCoking()
    {
        InstanceProduct(_nicecoking);
    }
    public void AddNiceSpeach()
    {
        InstanceProduct(_nicespeach);
    }

    public void AddNiceProgramming()
    {
        InstanceProduct(_niceprogramming);
    }

    public void AddPlayGames()
    {
        InstanceProduct(_playgames);
    }

    public void Reset()
    {
        Complect = new Compectation();
    }

    private void InstanceProduct(ProductData reference)
    {
        var instance = new ProductData(reference.Name, reference.Stars);
        Complect.Add(instance);
    }
}
