namespace Telephone
{
    interface IMemory : ITurnOnOffable
    {
        int SaveData(string data);
        string GetData(int address);
    }
}