using UnityEngine;
using static UnityEditor.ObjectChangeEventStream;

public class BuyingClient : MonoBehaviour
{
    [SerializeField] private GameObject _builderObj;
    private void Start()
    {
        var builder = _builderObj.GetComponent<StoreSmartphoneBuilder>();
        if (_builderObj == null) return;
        GirlGeneral(builder);
        Girl0(builder);
        Girl1(builder);
        Girl2(builder);
        Girl3(builder);
        Girl4(builder);
    }

    private void GirlGeneral(StoreSmartphoneBuilder builder)
    {
        builder.Add();
        builder.AddBeautiful();
        builder.AddSmart();
        builder.AddYoung();
        builder.AddRich();
        builder.AddCharismatic();
        builder.AddNotJealous();
        builder.AddPurposeful();
        builder.AddNiceCoking();
        builder.AddNiceSpeach();
        builder.AddNiceProgramming();
        builder.AddPlayGames();

        PrintDataSale(builder);

        builder.Reset();
    }
    private void Girl0(StoreSmartphoneBuilder builder)
    {
        builder.Add();

        PrintDataSale(builder);

        builder.Reset();
    }
    private void Girl1(StoreSmartphoneBuilder builder)
    {
        builder.Add1();
        builder.AddNotJealous();
        builder.AddPurposeful();
        builder.AddPlayGames();

        PrintDataSale(builder);

        builder.Reset();
    }
    private void Girl2(StoreSmartphoneBuilder builder)
    {
        builder.Add2();
        builder.AddBeautiful();
        builder.AddNotJealous();
        builder.AddNiceCoking();
        builder.AddYoung();

        PrintDataSale(builder);

        builder.Reset();
    }
    private void Girl3(StoreSmartphoneBuilder builder)
    {
        builder.Add3();
        builder.AddSmart();
        builder.AddYoung();
        builder.AddRich();
        builder.AddCharismatic();

        PrintDataSale(builder);

        builder.Reset();
    }
    private void Girl4(StoreSmartphoneBuilder builder)
    {
        builder.Add4();
        builder.AddYoung();
        builder.AddNiceSpeach();
        builder.AddNiceProgramming();
        builder.AddPlayGames();

        PrintDataSale(builder);

        builder.Reset();
    }

    public void PrintDataSale(StoreSmartphoneBuilder builder)
    {
        var data = builder.Complect.GetPurchaseData();

        print("Подобрана новая девушка!!!");

        for (int i = 0; i < data.Length; i++)
        {
            print(data[i]);
        }
    }
}
