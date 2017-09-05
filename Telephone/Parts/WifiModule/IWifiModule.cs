namespace Telephone
{
    interface IWifiModule : ITurnOnOffable
    {
        void Connect();
        string GetData(string url);
        void SendData(string data);
    }
}