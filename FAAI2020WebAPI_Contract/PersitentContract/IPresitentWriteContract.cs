namespace FAAI2020WebAPI_Contract.PersitentContract
{
    public interface IPresitentWriteContract
    {
        void Write<T>(T data);
    }
}
