namespace Telephone
{
    interface IOperationSystem : ITurnOnOffable
    {
        void Load();
        void Login();
        int SaveData(string data);
        string GetData(int address);
    }
}