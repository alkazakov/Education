namespace Telephone
{
    interface IHardDrive : ITurnOnOffable
    {
        int SaveData(string data);
        string GetData(int address);
    }
}