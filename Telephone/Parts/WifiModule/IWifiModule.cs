namespace Telephone
{
    interface IWifiModule : ITurnOnOffable
    {
        string Ip { get; set; }
        void Connect();
        string GetData(string url);
        void SendData(string data);
    }
}