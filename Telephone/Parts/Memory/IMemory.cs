namespace Telephone
{
    /// <summary>
    /// Common interface for all Memory types
    /// </summary>
    interface IMemory : ITurnOnOffable
    {
        int SaveData(string data);
        string GetData(int address);
    }
}