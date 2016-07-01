
namespace XendApi.Interface
{
    public interface IXendCredentials
    {
        string XKey { get; }
        string Xpass { get; }

        string MyXendAccount { get; }

        string AppId { get;}
    }
}
