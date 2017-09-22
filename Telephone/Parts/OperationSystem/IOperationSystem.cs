namespace Telephone
{
    /// <summary>
    /// Common interface for all operation system
    /// </summary>
    interface IOperationSystem : ITurnOnOffable
    {
        void Load();
        void Login();
        int SaveData(string data);
        string GetData(int address);
    }
}