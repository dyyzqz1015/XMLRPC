using CookComputing.XmlRpc;

namespace Client
{
    [XmlRpcUrl("http://localhost:8081")]
    public interface IIsEven : IXmlRpcProxy
    {
        [XmlRpcMethod("is_even")]
        bool is_even(int n);

        [XmlRpcMethod("add")]
        int add(int n,int m);
    }
}
